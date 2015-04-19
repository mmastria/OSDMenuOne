#include <EEPROM.h>
#include <Arduino.h>
#include <ModbusSlave.h>

enum {
  
  MB_UP,
  MB_DOWN,
  MB_LEFT,
  MB_RIGHT,
  MB_SET,
  
  MB_CAM_SWITCH,
  MB_CAM_STATUS,  
  MB_NIGHT_SENSOR,
  MB_RAIN_SENSOR,  
  MB_NIGHT_RLTYPE,
  MB_RAIN_RLTYPE,
  
  MB_SAVE_SETTINGS,
  
  MB_REGS
};

enum {
  SWITCH_OFF,
  SWITCH_ON,
  SWITCH_AUTO
};

enum {
  POWER_OFF,
  POWER_ON
};

enum {
  NORMALLY_OPEN,
  NORMALLY_CLOSED
};

#define NIGHT_SENSOR   2

#define CMD_UP         3
#define CMD_DOWN       4
#define CMD_LEFT       5
#define CMD_RIGHT      6
#define CMD_SET        7

#define RAIN_SENSOR    8

#define POWER_CAM    17 // A3

#define EE_SETTED 0
#define EE_CAM_SWITCH 1
#define EE_NIGHT_RLTYPE 2
#define EE_RAIN_RLTYPE 3

ModbusSlave mbs;
boolean change=false;
byte camSwitch;
byte camPower;
byte nightRlType=NORMALLY_OPEN;
byte rainRlType=NORMALLY_CLOSED;
int regs[MB_REGS];

void setup() {
  
  pinMode(CMD_UP, OUTPUT);
  pinMode(CMD_DOWN, OUTPUT);
  pinMode(CMD_LEFT, OUTPUT);
  pinMode(CMD_RIGHT, OUTPUT);
  pinMode(CMD_SET, OUTPUT);

  pinMode(POWER_CAM, OUTPUT);
  digitalWrite(POWER_CAM, HIGH);

  pinMode(NIGHT_SENSOR, INPUT); // external pull-up - Closed = Night (NO)
  pinMode(RAIN_SENSOR, INPUT); // external pull-up - Closed = Not Raining (NC)

  Serial.begin(9600);
  while(!Serial) {;}
  Serial.println();
  Serial.println("OSDMenuOne");
  Serial.println("Marco Mastria - 19-April-2015");
  Serial.println("Rain Sensor: D8 (NO)");
  Serial.println("Night Sensor: D2 (NC)");
  Serial.println("ModBus Serial 19200");
  Serial.println();
  delay(100);

  mbs.configure(1, 19200, 'n', 0);
  for(byte i=0; i<MB_REGS; i++)
    regs[i]=0;
  camPower=POWER_OFF;  
  readSettings();
  delay(100);
}

void loop() {
  
  setCamPower();

  for(byte i=0; i<MB_REGS; i++)
    regs[i]=0;
  regs[MB_CAM_SWITCH]=camSwitch;
  regs[MB_CAM_STATUS]=camPower;
  regs[MB_NIGHT_RLTYPE]=nightRlType;
  regs[MB_RAIN_RLTYPE]=rainRlType;

  regs[MB_NIGHT_SENSOR]=(digitalRead(NIGHT_SENSOR)!=nightRlType ? 1 : 0);
  regs[MB_RAIN_SENSOR]=(digitalRead(RAIN_SENSOR)!=rainRlType ? 1 : 0);

  if(mbs.update(regs, MB_REGS)>4) {
    if(regs[MB_CAM_SWITCH]!=camSwitch) { camSwitch=(byte)regs[MB_CAM_SWITCH]; setCamPower(); }
    if(regs[MB_NIGHT_RLTYPE]!=nightRlType) { nightRlType=(byte)regs[MB_NIGHT_RLTYPE]; setCamPower(); }
    if(regs[MB_RAIN_RLTYPE]!=rainRlType) { rainRlType=(byte)regs[MB_RAIN_RLTYPE]; setCamPower(); }
    if(regs[MB_SAVE_SETTINGS]==1) { saveSettings(); }
    if(regs[MB_UP]==1) { change=true; digitalWrite(CMD_UP, HIGH); }
    if(regs[MB_DOWN]==1) { change=true; digitalWrite(CMD_DOWN, HIGH); }
    if(regs[MB_LEFT]==1) { change=true; digitalWrite(CMD_LEFT, HIGH); }
    if(regs[MB_RIGHT]==1) { change=true; digitalWrite(CMD_RIGHT, HIGH); }
    if(regs[MB_SET]==1) { change=true; digitalWrite(CMD_SET, HIGH); }
    if(change) {
      delay(50);
      digitalWrite(CMD_UP, LOW);
      digitalWrite(CMD_DOWN, LOW);
      digitalWrite(CMD_LEFT, LOW);
      digitalWrite(CMD_RIGHT, LOW);
      digitalWrite(CMD_SET, LOW);
      change=false;
    }
  }
  delay(1);
  
}

void setCamPower() {
  switch(camSwitch) {
    case SWITCH_ON:
      camPower=POWER_ON;
      digitalWrite(POWER_CAM, LOW);
      break;
    case SWITCH_OFF:
      camPower=POWER_OFF;
      digitalWrite(POWER_CAM, HIGH);
      break;
    case SWITCH_AUTO:
      if(digitalRead(NIGHT_SENSOR)!=nightRlType and digitalRead(RAIN_SENSOR)!=rainRlType) {
        camPower=POWER_ON;
        digitalWrite(POWER_CAM, LOW);
      }
      else {
        camPower=POWER_OFF;
        digitalWrite(POWER_CAM, HIGH);
      }
      break;
  }
}

void saveSettings() {
  EEPROM.write(EE_SETTED, 1);
  EEPROM.write(EE_CAM_SWITCH, camSwitch);
  EEPROM.write(EE_RAIN_RLTYPE, rainRlType);
  EEPROM.write(EE_NIGHT_RLTYPE, nightRlType);
}

void readSettings() {
  if(EEPROM.read(EE_SETTED)==1) {
    camSwitch = EEPROM.read(EE_CAM_SWITCH);
    rainRlType = EEPROM.read(EE_RAIN_RLTYPE);
    nightRlType = EEPROM.read(EE_NIGHT_RLTYPE);
    checkSettings();
  }
  else {
    resetSettings();
  }
}

void checkSettings() {
  boolean ok=true;
  if(camSwitch<SWITCH_OFF or camSwitch>SWITCH_AUTO) {ok=false;}
  if(rainRlType<NORMALLY_OPEN or rainRlType>NORMALLY_CLOSED) {ok=false;}
  if(nightRlType<NORMALLY_OPEN or nightRlType>NORMALLY_CLOSED) {ok=false;}
  if(!ok)
    resetSettings();
}

void resetSettings() {
  camSwitch=SWITCH_AUTO;
  rainRlType = NORMALLY_CLOSED;
  nightRlType = NORMALLY_OPEN;
}

