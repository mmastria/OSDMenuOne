using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace OSDMenu
{
    public partial class OSDMenu : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture(); 
        
        const int MB_UP = 0;
        const int MB_DOWN = 1;
        const int MB_LEFT = 2;
        const int MB_RIGHT = 3;
        const int MB_SET = 4;
        const int MB_CAM_SELECT = 5;
        const int MB_CAM1_SWITCH = 6;
        const int MB_CAM2_SWITCH = 7;
        const int MB_CAM3_SWITCH = 8;
        const int MB_CAM1_STATUS = 9;
        const int MB_CAM2_STATUS = 10;
        const int MB_CAM3_STATUS = 11;
        const int MB_NIGHT_SENSOR = 12;
        const int MB_RAIN_SENSOR = 13;
        const int MB_NIGHT_RLTYPE = 14;
        const int MB_RAIN_RLTYPE = 15;
        const int MB_SAVE_SETTINGS = 16;
        const int MB_REGS = 17;

        const int CAM1 = 0;
        const int CAM2 = 1;
        const int CAM3 = 2;

        const int SWITCH_OFF = 0;
        const int SWITCH_ON = 1;
        const int SWITCH_AUTO = 2;

        const int POWER_OFF = 0;
        const int POWER_ON = 1;

        const int BUTTON_OFF = 0;
        const int BUTTON_ON = 1;

        const int NORMALLY_OPEN = 0;
        const int NORMALLY_CLOSED = 1;

        Color COLOR_ON = Color.FromArgb(192, 255, 192);
        Color COLOR_OFF = Color.FromArgb(255, 192, 192);

        private ModbusMasterSerial mm;

        public OSDMenu()
        {
            InitializeComponent();
            reconnect();
        }

        ~OSDMenu()
        {
            try
            {
                mm.Disconnect();
            }
            catch (Exception) { }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }
        
        private void OSDMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Left > 0)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    Properties.Settings.Default["XPos"] = this.Left;
                    Properties.Settings.Default["YPos"] = this.Top;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cOM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(1);
        }

        private void cOM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(2);
        }

        private void cOM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(3);
        }

        private void cOM4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(4);
        }

        private void cOM5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(5);
        }

        private void cOM6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(6);
        }

        private void cOM7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(7);
        }

        private void cOM8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(8);
        }

        private void cOM9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(9);
        }

        private void cOM10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(10);
        }

        private void cOM11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(11);
        }

        private void cOM12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(12);
        }

        private void cOM13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(13);
        }

        private void cOM14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(14);
        }

        private void cOM15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(15);
        }

        private void cOM16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommPort(16);
        }

        private void setCommPort(int port)
        {
            cOM1ToolStripMenuItem.Checked = (port == 1 ? true : false);
            cOM2ToolStripMenuItem.Checked = (port == 2 ? true : false);
            cOM3ToolStripMenuItem.Checked = (port == 3 ? true : false);
            cOM4ToolStripMenuItem.Checked = (port == 4 ? true : false);
            cOM5ToolStripMenuItem.Checked = (port == 5 ? true : false);
            cOM6ToolStripMenuItem.Checked = (port == 6 ? true : false);
            cOM7ToolStripMenuItem.Checked = (port == 7 ? true : false);
            cOM8ToolStripMenuItem.Checked = (port == 8 ? true : false);
            cOM9ToolStripMenuItem.Checked = (port == 9 ? true : false);
            cOM10ToolStripMenuItem.Checked = (port == 10 ? true : false);
            cOM11ToolStripMenuItem.Checked = (port == 11 ? true : false);
            cOM12ToolStripMenuItem.Checked = (port == 12 ? true : false);
            cOM13ToolStripMenuItem.Checked = (port == 13 ? true : false);
            cOM14ToolStripMenuItem.Checked = (port == 14 ? true : false);
            cOM15ToolStripMenuItem.Checked = (port == 15 ? true : false);
            cOM16ToolStripMenuItem.Checked = (port == 16 ? true : false);
            Properties.Settings.Default["CommPort"] = "COM" + port.ToString();
            Properties.Settings.Default.Save();
            reconnect();
        }

        private void setCommPortMenu(String commPort)
        {
            switch (commPort)
            {
                case "COM1": 
                    cOM1ToolStripMenuItem.Checked = true;
                    break;
                case "COM2": 
                    cOM2ToolStripMenuItem.Checked = true;
                    break;
                case "COM3":
                    cOM3ToolStripMenuItem.Checked = true;
                    break;
                case "COM4":
                    cOM4ToolStripMenuItem.Checked = true;
                    break;
                case "COM5":
                    cOM5ToolStripMenuItem.Checked = true;
                    break;
                case "COM6":
                    cOM6ToolStripMenuItem.Checked = true;
                    break;
                case "COM7":
                    cOM7ToolStripMenuItem.Checked = true;
                    break;
                case "COM8":
                    cOM8ToolStripMenuItem.Checked = true;
                    break;
                case "COM9":
                    cOM9ToolStripMenuItem.Checked = true;
                    break;
                case "COM10":
                    cOM10ToolStripMenuItem.Checked = true;
                    break;
                case "COM11":
                    cOM11ToolStripMenuItem.Checked = true;
                    break;
                case "COM12":
                    cOM12ToolStripMenuItem.Checked = true;
                    break;
                case "COM13":
                    cOM13ToolStripMenuItem.Checked = true;
                    break;
                case "COM14":
                    cOM14ToolStripMenuItem.Checked = true;
                    break;
                case "COM15":
                    cOM15ToolStripMenuItem.Checked = true;
                    break;
                case "COM16":
                    cOM16ToolStripMenuItem.Checked = true;
                    break;
            }

        }

        private void up_Click(object sender, EventArgs e)
        {
            up.Select();
            try
            {
                mm.WriteSingleRegister(1, MB_UP, (ushort) BUTTON_ON);
            }
            catch (Exception) { }
        }

        private void down_Click(object sender, EventArgs e)
        {
            down.Select();
            try
            {
                mm.WriteSingleRegister(1, MB_DOWN, (ushort) BUTTON_ON);
            }
            catch (Exception) { }
        }

        private void left_Click(object sender, EventArgs e)
        {
            left.Select();
            try
            {
                mm.WriteSingleRegister(1, MB_LEFT, (ushort) BUTTON_ON);
            }
            catch (Exception) { }
        }

        private void right_Click(object sender, EventArgs e)
        {
            right.Select();
            try
            {
                mm.WriteSingleRegister(1, MB_RIGHT, (ushort) BUTTON_ON);
            }
            catch (Exception) { }
        }

        private void set_Click(object sender, EventArgs e)
        {
            set.Select();
            try
            {
                mm.WriteSingleRegister(1, MB_SET, (ushort) BUTTON_ON);
            }
            catch (Exception) { }
        }

        private void selectCam1_CheckedChanged(object sender, EventArgs e)
        {
            if(selectCam1.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM_SELECT, (ushort)CAM1);
                }
                catch (Exception) { }
        }

        private void selectCam2_CheckedChanged(object sender, EventArgs e)
        {
            if (selectCam2.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM_SELECT, (ushort)CAM2);
                }
                catch (Exception) { }
        }

        private void selectCam3_CheckedChanged(object sender, EventArgs e)
        {
            if (selectCam3.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM_SELECT, (ushort)CAM3);
                }
                catch (Exception) { }
        }

        private void cam1On_CheckedChanged(object sender, EventArgs e)
        {
            if (cam1On.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM1_SWITCH, (ushort)SWITCH_ON);
                }
                catch (Exception) { }
        }

        private void can1Off_CheckedChanged(object sender, EventArgs e)
        {
            if (cam1Off.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM1_SWITCH, (ushort)SWITCH_OFF);
                }
                catch (Exception) { }
        }

        private void cam1Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (cam1Auto.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM1_SWITCH, (ushort)SWITCH_AUTO);
                }
                catch (Exception) { }
        }

        private void cam2On_CheckedChanged(object sender, EventArgs e)
        {
            if (cam2On.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM2_SWITCH, (ushort)SWITCH_ON);
                }
                catch (Exception) { }
        }

        private void cam2Off_CheckedChanged(object sender, EventArgs e)
        {
            if (cam2Off.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM2_SWITCH, (ushort)SWITCH_OFF);
                }
                catch (Exception) { }
        }

        private void cam2Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (cam2Auto.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM2_SWITCH, (ushort)SWITCH_AUTO);
                }
                catch (Exception) { }
        }

        private void cam3On_CheckedChanged(object sender, EventArgs e)
        {
            if (cam3On.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM3_SWITCH, (ushort)SWITCH_ON);
                }
                catch (Exception) { }
        }

        private void cam3Off_CheckedChanged(object sender, EventArgs e)
        {
            if (cam3Off.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM3_SWITCH, (ushort)SWITCH_OFF);
                }
                catch (Exception) { }
        }

        private void cam3Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (cam3Auto.Checked)
                try
                {
                    mm.WriteSingleRegister(1, MB_CAM3_SWITCH, (ushort)SWITCH_AUTO);
                }
                catch (Exception) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            readModbus();
            timer1.Enabled = true;
        }


        private void readModbus()
        {
            try
            {
                ushort[] regs;
                regs = mm.ReadHoldingRegisters(1, 0, MB_REGS);

                commStatus.Text = "COMM OK";

                if ((regs != null) && (regs.Length==MB_REGS))
                {
                    switch (regs[MB_CAM_SELECT])
                    {
                        case CAM1:
                            selectCam1.Checked = true;
                            break;
                        case CAM2:
                            selectCam2.Checked = true;
                            break;
                        case CAM3:
                            selectCam3.Checked = true;
                            break;
                    }

                    switch (regs[MB_CAM1_SWITCH])
                    {
                        case SWITCH_OFF:
                            cam1Off.Checked = true;
                            break;
                        case SWITCH_ON:
                            cam1On.Checked = true;
                            break;
                        case SWITCH_AUTO:
                            cam1Auto.Checked = true;
                            break;
                    }

                    switch (regs[MB_CAM2_SWITCH])
                    {
                        case SWITCH_OFF:
                            cam2Off.Checked = true;
                            break;
                        case SWITCH_ON:
                            cam2On.Checked = true;
                            break;
                        case SWITCH_AUTO:
                            cam2Auto.Checked = true;
                            break;
                    }

                    switch (regs[MB_CAM3_SWITCH])
                    {
                        case SWITCH_OFF:
                            cam3Off.Checked = true;
                            break;
                        case SWITCH_ON:
                            cam3On.Checked = true;
                            break;
                        case SWITCH_AUTO:
                            cam3Auto.Checked = true;
                            break;
                    }

                    if (regs[MB_RAIN_RLTYPE] == NORMALLY_OPEN)
                    {
                        noRainToolStripMenuItem.Checked = true;
                        ncRainToolStripMenuItem.Checked = false;
                    }
                    else
                    {
                        noRainToolStripMenuItem.Checked = false;
                        ncRainToolStripMenuItem.Checked = true;
                    }

                    if (regs[MB_NIGHT_RLTYPE] == NORMALLY_OPEN)
                    {
                        noNightToolStripMenuItem.Checked = true;
                        ncNightToolStripMenuItem.Checked = false;
                    }
                    else
                    {
                        noNightToolStripMenuItem.Checked = false;
                        ncNightToolStripMenuItem.Checked = true;
                    }

                    if (regs[MB_CAM1_STATUS] == 1)
                    {
                        cam1Status.Text = "on";
                        cam1Status.BackColor = COLOR_ON;
                    }
                    else
                    {
                        cam1Status.Text = "off";
                        cam1Status.BackColor = COLOR_OFF;
                    }

                    if (regs[MB_CAM2_STATUS] == 1)
                    {
                        cam2Status.Text = "on";
                        cam2Status.BackColor = COLOR_ON;
                    }
                    else
                    {
                        cam2Status.Text = "off";
                        cam2Status.BackColor = COLOR_OFF;
                    }

                    if (regs[MB_CAM3_STATUS] == 1)
                    {
                        cam3Status.Text = "on";
                        cam3Status.BackColor = COLOR_ON;
                    }
                    else
                    {
                        cam3Status.Text = "off";
                        cam3Status.BackColor = COLOR_OFF;
                    }

                    if (regs[MB_NIGHT_SENSOR] == 1)
                        sensorNight.Text = "Nighttime";
                    else
                        sensorNight.Text = "Daytime";

                    if (regs[MB_RAIN_SENSOR] == 1)
                        sensorRain.Text = "Not Raining";
                    else
                        sensorRain.Text = "Raining";
                }

            }
            catch (Exception) { }
            {
                commStatus.Text = "COMM ERR";
                reconnect();
            }
        }

        private void saveNOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mm.WriteSingleRegister(1, MB_SAVE_SETTINGS, (ushort)1);
        }

        private void reconnect()
        {
            if (Properties.Settings.Default.CommPort != "")
            {
                try
                {
                    if(mm!=null)
                        mm.Disconnect();
                }
                catch (Exception) { }
                try
                {
                    mm = new ModbusMasterSerial(ModbusSerialType.RTU, Properties.Settings.Default.CommPort, 19200, 8, Parity.None, StopBits.One, Handshake.None);
                    setCommPortMenu(Properties.Settings.Default.CommPort);
                    mm.RxTimeout = 500;
                    mm.Connect();
                    commStatus.Text = "COMM OK";
                }
                catch (Exception) {
                    commStatus.Text = "COMM ERR";
                }
            }

        }

        private void normalOpenedNightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noNightToolStripMenuItem.Checked)
            {
                ncNightToolStripMenuItem.Checked = false;
                try
                {
                    mm.WriteSingleRegister(1, MB_NIGHT_RLTYPE, (ushort)NORMALLY_OPEN);
                }
                catch (Exception) { }
            }
        }

        private void normalClosedNightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ncNightToolStripMenuItem.Checked)
            {
                noNightToolStripMenuItem.Checked = false;
                try
                {
                    mm.WriteSingleRegister(1, MB_NIGHT_RLTYPE, (ushort)NORMALLY_CLOSED);
                }
                catch (Exception) { }
            }
        }

        private void normalOpenedRainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noRainToolStripMenuItem.Checked)
            {
                ncRainToolStripMenuItem.Checked = false;
                try
                {
                    mm.WriteSingleRegister(1, MB_RAIN_RLTYPE, (ushort)NORMALLY_OPEN);
                }
                catch (Exception) { }
            }
        }

        private void normalClosedRainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ncRainToolStripMenuItem.Checked)
            {
                noRainToolStripMenuItem.Checked = false;
                try
                {
                    mm.WriteSingleRegister(1, MB_RAIN_RLTYPE, (ushort)NORMALLY_CLOSED);
                }
                catch (Exception) { }
            }
        }

        private void OSDMenu_Shown(object sender, EventArgs e)
        {
            Hide();
            if (Properties.Settings.Default.YPos > 0)
            {
                this.Location = new Point(Properties.Settings.Default.XPos, Properties.Settings.Default.YPos);
            }
        }

    }
}
