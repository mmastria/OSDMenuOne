using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OSDMenu
{
    partial class OSDMenu
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //left
            if (keyData == Keys.Left)
            {
                left.PerformClick();
                return true; //for the active control to see the keypress, return false
            }
            //right
            else if (keyData == Keys.Right)
            {
                right.PerformClick();
                return true; //for the active control to see the keypress, return false
            }
            //up
            else if (keyData == Keys.Up)
            {
                up.PerformClick();
                return true; //for the active control to see the keypress, return false
            }
            //down
            else if (keyData == Keys.Down)
            {
                down.PerformClick();
                return true; //for the active control to see the keypress, return false
            }
            //enter
            else if (keyData == Keys.Enter || keyData == Keys.Clear)
            {
                set.PerformClick();
                return true; //for the active control to see the keypress, return false
            }

            //esc
            else if (keyData == Keys.Escape)
            {
                Hide();
                return true; //for the active control to see the keypress, return false
            }

            else
            {
//                System.Diagnostics.Debug.Write(keyData);
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSDMenu));
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.set = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightSensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noNightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ncNightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainSensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noRainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ncRainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveControllerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cam1Status = new System.Windows.Forms.Label();
            this.cam1Auto = new System.Windows.Forms.RadioButton();
            this.cam1Off = new System.Windows.Forms.RadioButton();
            this.cam1On = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sensorNight = new System.Windows.Forms.ToolStripStatusLabel();
            this.sensorRain = new System.Windows.Forms.ToolStripStatusLabel();
            this.commStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cam2Status = new System.Windows.Forms.Label();
            this.cam2Auto = new System.Windows.Forms.RadioButton();
            this.cam2Off = new System.Windows.Forms.RadioButton();
            this.cam2On = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cam3Status = new System.Windows.Forms.Label();
            this.cam3Auto = new System.Windows.Forms.RadioButton();
            this.cam3Off = new System.Windows.Forms.RadioButton();
            this.cam3On = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.selectCam3 = new System.Windows.Forms.RadioButton();
            this.selectCam2 = new System.Windows.Forms.RadioButton();
            this.selectCam1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(66, 26);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(50, 50);
            this.up.TabIndex = 1;
            this.up.Text = "UP";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(66, 138);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(50, 50);
            this.down.TabIndex = 2;
            this.down.Text = "DOWN";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(10, 82);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(50, 50);
            this.left.TabIndex = 3;
            this.left.Text = "LEFT";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(122, 82);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(50, 50);
            this.right.TabIndex = 4;
            this.right.Text = "RIGHT";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(66, 82);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(50, 50);
            this.set.TabIndex = 5;
            this.set.Text = "SET";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "OSDMenu";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.selectCOMPortToolStripMenuItem,
            this.nightSensorToolStripMenuItem,
            this.rainSensorToolStripMenuItem,
            this.saveControllerSettingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 142);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // selectCOMPortToolStripMenuItem
            // 
            this.selectCOMPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOM1ToolStripMenuItem,
            this.cOM2ToolStripMenuItem,
            this.cOM3ToolStripMenuItem,
            this.cOM4ToolStripMenuItem,
            this.cOM5ToolStripMenuItem,
            this.cOM6ToolStripMenuItem,
            this.cOM7ToolStripMenuItem,
            this.cOM8ToolStripMenuItem,
            this.cOM9ToolStripMenuItem,
            this.cOM10ToolStripMenuItem,
            this.cOM11ToolStripMenuItem,
            this.cOM12ToolStripMenuItem,
            this.cOM13ToolStripMenuItem,
            this.cOM14ToolStripMenuItem,
            this.cOM15ToolStripMenuItem,
            this.cOM16ToolStripMenuItem});
            this.selectCOMPortToolStripMenuItem.Name = "selectCOMPortToolStripMenuItem";
            this.selectCOMPortToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.selectCOMPortToolStripMenuItem.Text = "Select COM Port";
            // 
            // cOM1ToolStripMenuItem
            // 
            this.cOM1ToolStripMenuItem.Name = "cOM1ToolStripMenuItem";
            this.cOM1ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM1ToolStripMenuItem.Text = "COM1";
            this.cOM1ToolStripMenuItem.Click += new System.EventHandler(this.cOM1ToolStripMenuItem_Click);
            // 
            // cOM2ToolStripMenuItem
            // 
            this.cOM2ToolStripMenuItem.Name = "cOM2ToolStripMenuItem";
            this.cOM2ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM2ToolStripMenuItem.Text = "COM2";
            this.cOM2ToolStripMenuItem.Click += new System.EventHandler(this.cOM2ToolStripMenuItem_Click);
            // 
            // cOM3ToolStripMenuItem
            // 
            this.cOM3ToolStripMenuItem.Name = "cOM3ToolStripMenuItem";
            this.cOM3ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM3ToolStripMenuItem.Text = "COM3";
            this.cOM3ToolStripMenuItem.Click += new System.EventHandler(this.cOM3ToolStripMenuItem_Click);
            // 
            // cOM4ToolStripMenuItem
            // 
            this.cOM4ToolStripMenuItem.Name = "cOM4ToolStripMenuItem";
            this.cOM4ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM4ToolStripMenuItem.Text = "COM4";
            this.cOM4ToolStripMenuItem.Click += new System.EventHandler(this.cOM4ToolStripMenuItem_Click);
            // 
            // cOM5ToolStripMenuItem
            // 
            this.cOM5ToolStripMenuItem.Name = "cOM5ToolStripMenuItem";
            this.cOM5ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM5ToolStripMenuItem.Text = "COM5";
            this.cOM5ToolStripMenuItem.Click += new System.EventHandler(this.cOM5ToolStripMenuItem_Click);
            // 
            // cOM6ToolStripMenuItem
            // 
            this.cOM6ToolStripMenuItem.Name = "cOM6ToolStripMenuItem";
            this.cOM6ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM6ToolStripMenuItem.Text = "COM6";
            this.cOM6ToolStripMenuItem.Click += new System.EventHandler(this.cOM6ToolStripMenuItem_Click);
            // 
            // cOM7ToolStripMenuItem
            // 
            this.cOM7ToolStripMenuItem.Name = "cOM7ToolStripMenuItem";
            this.cOM7ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM7ToolStripMenuItem.Text = "COM7";
            this.cOM7ToolStripMenuItem.Click += new System.EventHandler(this.cOM7ToolStripMenuItem_Click);
            // 
            // cOM8ToolStripMenuItem
            // 
            this.cOM8ToolStripMenuItem.Name = "cOM8ToolStripMenuItem";
            this.cOM8ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM8ToolStripMenuItem.Text = "COM8";
            this.cOM8ToolStripMenuItem.Click += new System.EventHandler(this.cOM8ToolStripMenuItem_Click);
            // 
            // cOM9ToolStripMenuItem
            // 
            this.cOM9ToolStripMenuItem.Name = "cOM9ToolStripMenuItem";
            this.cOM9ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM9ToolStripMenuItem.Text = "COM9";
            this.cOM9ToolStripMenuItem.Click += new System.EventHandler(this.cOM9ToolStripMenuItem_Click);
            // 
            // cOM10ToolStripMenuItem
            // 
            this.cOM10ToolStripMenuItem.Name = "cOM10ToolStripMenuItem";
            this.cOM10ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM10ToolStripMenuItem.Text = "COM10";
            this.cOM10ToolStripMenuItem.Click += new System.EventHandler(this.cOM10ToolStripMenuItem_Click);
            // 
            // cOM11ToolStripMenuItem
            // 
            this.cOM11ToolStripMenuItem.Name = "cOM11ToolStripMenuItem";
            this.cOM11ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM11ToolStripMenuItem.Text = "COM11";
            this.cOM11ToolStripMenuItem.Click += new System.EventHandler(this.cOM11ToolStripMenuItem_Click);
            // 
            // cOM12ToolStripMenuItem
            // 
            this.cOM12ToolStripMenuItem.Name = "cOM12ToolStripMenuItem";
            this.cOM12ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM12ToolStripMenuItem.Text = "COM12";
            this.cOM12ToolStripMenuItem.Click += new System.EventHandler(this.cOM12ToolStripMenuItem_Click);
            // 
            // cOM13ToolStripMenuItem
            // 
            this.cOM13ToolStripMenuItem.Name = "cOM13ToolStripMenuItem";
            this.cOM13ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM13ToolStripMenuItem.Text = "COM13";
            this.cOM13ToolStripMenuItem.Click += new System.EventHandler(this.cOM13ToolStripMenuItem_Click);
            // 
            // cOM14ToolStripMenuItem
            // 
            this.cOM14ToolStripMenuItem.Name = "cOM14ToolStripMenuItem";
            this.cOM14ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM14ToolStripMenuItem.Text = "COM14";
            this.cOM14ToolStripMenuItem.Click += new System.EventHandler(this.cOM14ToolStripMenuItem_Click);
            // 
            // cOM15ToolStripMenuItem
            // 
            this.cOM15ToolStripMenuItem.Name = "cOM15ToolStripMenuItem";
            this.cOM15ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM15ToolStripMenuItem.Text = "COM15";
            this.cOM15ToolStripMenuItem.Click += new System.EventHandler(this.cOM15ToolStripMenuItem_Click);
            // 
            // cOM16ToolStripMenuItem
            // 
            this.cOM16ToolStripMenuItem.Name = "cOM16ToolStripMenuItem";
            this.cOM16ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cOM16ToolStripMenuItem.Text = "COM16";
            this.cOM16ToolStripMenuItem.Click += new System.EventHandler(this.cOM16ToolStripMenuItem_Click);
            // 
            // nightSensorToolStripMenuItem
            // 
            this.nightSensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noNightToolStripMenuItem,
            this.ncNightToolStripMenuItem});
            this.nightSensorToolStripMenuItem.Name = "nightSensorToolStripMenuItem";
            this.nightSensorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.nightSensorToolStripMenuItem.Text = "Night Sensor";
            // 
            // noNightToolStripMenuItem
            // 
            this.noNightToolStripMenuItem.CheckOnClick = true;
            this.noNightToolStripMenuItem.Name = "noNightToolStripMenuItem";
            this.noNightToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.noNightToolStripMenuItem.Text = "Normally-Open (NO)";
            this.noNightToolStripMenuItem.Click += new System.EventHandler(this.normalOpenedNightToolStripMenuItem_Click);
            // 
            // ncNightToolStripMenuItem
            // 
            this.ncNightToolStripMenuItem.CheckOnClick = true;
            this.ncNightToolStripMenuItem.Name = "ncNightToolStripMenuItem";
            this.ncNightToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ncNightToolStripMenuItem.Text = "Normally-Closed (NC)";
            this.ncNightToolStripMenuItem.Click += new System.EventHandler(this.normalClosedNightToolStripMenuItem_Click);
            // 
            // rainSensorToolStripMenuItem
            // 
            this.rainSensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noRainToolStripMenuItem,
            this.ncRainToolStripMenuItem});
            this.rainSensorToolStripMenuItem.Name = "rainSensorToolStripMenuItem";
            this.rainSensorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.rainSensorToolStripMenuItem.Text = "Rain Sensor";
            // 
            // noRainToolStripMenuItem
            // 
            this.noRainToolStripMenuItem.CheckOnClick = true;
            this.noRainToolStripMenuItem.Name = "noRainToolStripMenuItem";
            this.noRainToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.noRainToolStripMenuItem.Text = "Normally-Open (NO)";
            this.noRainToolStripMenuItem.Click += new System.EventHandler(this.normalOpenedRainToolStripMenuItem_Click);
            // 
            // ncRainToolStripMenuItem
            // 
            this.ncRainToolStripMenuItem.CheckOnClick = true;
            this.ncRainToolStripMenuItem.Name = "ncRainToolStripMenuItem";
            this.ncRainToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ncRainToolStripMenuItem.Text = "Normally-Closed (NC)";
            this.ncRainToolStripMenuItem.Click += new System.EventHandler(this.normalClosedRainToolStripMenuItem_Click);
            // 
            // saveControllerSettingsToolStripMenuItem
            // 
            this.saveControllerSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.saveNOWToolStripMenuItem});
            this.saveControllerSettingsToolStripMenuItem.Name = "saveControllerSettingsToolStripMenuItem";
            this.saveControllerSettingsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveControllerSettingsToolStripMenuItem.Text = "Save Controller Settings";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // saveNOWToolStripMenuItem
            // 
            this.saveNOWToolStripMenuItem.Name = "saveNOWToolStripMenuItem";
            this.saveNOWToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveNOWToolStripMenuItem.Text = "Save NOW!";
            this.saveNOWToolStripMenuItem.Click += new System.EventHandler(this.saveNOWToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cam1Status);
            this.groupBox1.Controls.Add(this.cam1Auto);
            this.groupBox1.Controls.Add(this.cam1Off);
            this.groupBox1.Controls.Add(this.cam1On);
            this.groupBox1.Location = new System.Drawing.Point(199, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 52);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera 1 Power";
            // 
            // cam1Status
            // 
            this.cam1Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cam1Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cam1Status.Location = new System.Drawing.Point(143, 21);
            this.cam1Status.Name = "cam1Status";
            this.cam1Status.Size = new System.Drawing.Size(30, 20);
            this.cam1Status.TabIndex = 14;
            this.cam1Status.Text = "on";
            this.cam1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cam1Auto
            // 
            this.cam1Auto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cam1Auto.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam1Auto.Location = new System.Drawing.Point(94, 19);
            this.cam1Auto.Name = "cam1Auto";
            this.cam1Auto.Size = new System.Drawing.Size(45, 24);
            this.cam1Auto.TabIndex = 13;
            this.cam1Auto.Text = "AUTO";
            this.cam1Auto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam1Auto.UseVisualStyleBackColor = true;
            this.cam1Auto.CheckedChanged += new System.EventHandler(this.cam1Auto_CheckedChanged);
            // 
            // cam1Off
            // 
            this.cam1Off.Appearance = System.Windows.Forms.Appearance.Button;
            this.cam1Off.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam1Off.Location = new System.Drawing.Point(50, 19);
            this.cam1Off.Name = "cam1Off";
            this.cam1Off.Size = new System.Drawing.Size(45, 24);
            this.cam1Off.TabIndex = 12;
            this.cam1Off.Text = "OFF";
            this.cam1Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam1Off.UseVisualStyleBackColor = true;
            this.cam1Off.CheckedChanged += new System.EventHandler(this.can1Off_CheckedChanged);
            // 
            // cam1On
            // 
            this.cam1On.Appearance = System.Windows.Forms.Appearance.Button;
            this.cam1On.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam1On.Location = new System.Drawing.Point(6, 19);
            this.cam1On.Name = "cam1On";
            this.cam1On.Size = new System.Drawing.Size(45, 24);
            this.cam1On.TabIndex = 11;
            this.cam1On.Text = "ON";
            this.cam1On.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam1On.UseVisualStyleBackColor = true;
            this.cam1On.CheckedChanged += new System.EventHandler(this.cam1On_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.sensorNight,
            this.sensorRain,
            this.commStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 229);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(390, 24);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 19);
            this.toolStripStatusLabel2.Text = "[ESC - Minimize]";
            // 
            // sensorNight
            // 
            this.sensorNight.AutoSize = false;
            this.sensorNight.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sensorNight.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.sensorNight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sensorNight.Name = "sensorNight";
            this.sensorNight.Size = new System.Drawing.Size(100, 19);
            // 
            // sensorRain
            // 
            this.sensorRain.AutoSize = false;
            this.sensorRain.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sensorRain.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.sensorRain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sensorRain.Name = "sensorRain";
            this.sensorRain.Size = new System.Drawing.Size(100, 19);
            // 
            // commStatus
            // 
            this.commStatus.AutoSize = false;
            this.commStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.commStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.commStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.commStatus.Name = "commStatus";
            this.commStatus.Size = new System.Drawing.Size(70, 19);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.set);
            this.groupBox5.Controls.Add(this.up);
            this.groupBox5.Controls.Add(this.down);
            this.groupBox5.Controls.Add(this.left);
            this.groupBox5.Controls.Add(this.right);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 208);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "[ Arrows / Enter / Clear ]";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cam2Status);
            this.groupBox2.Controls.Add(this.cam2Auto);
            this.groupBox2.Controls.Add(this.cam2Off);
            this.groupBox2.Controls.Add(this.cam2On);
            this.groupBox2.Location = new System.Drawing.Point(199, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 52);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera 2 Power";
            // 
            // cam2Status
            // 
            this.cam2Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cam2Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cam2Status.Location = new System.Drawing.Point(143, 21);
            this.cam2Status.Name = "cam2Status";
            this.cam2Status.Size = new System.Drawing.Size(30, 20);
            this.cam2Status.TabIndex = 19;
            this.cam2Status.Text = "on";
            this.cam2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cam2Auto
            // 
            this.cam2Auto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cam2Auto.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam2Auto.Location = new System.Drawing.Point(94, 19);
            this.cam2Auto.Name = "cam2Auto";
            this.cam2Auto.Size = new System.Drawing.Size(45, 24);
            this.cam2Auto.TabIndex = 18;
            this.cam2Auto.Text = "AUTO";
            this.cam2Auto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam2Auto.UseVisualStyleBackColor = true;
            this.cam2Auto.CheckedChanged += new System.EventHandler(this.cam2Auto_CheckedChanged);
            // 
            // cam2Off
            // 
            this.cam2Off.Appearance = System.Windows.Forms.Appearance.Button;
            this.cam2Off.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam2Off.Location = new System.Drawing.Point(50, 19);
            this.cam2Off.Name = "cam2Off";
            this.cam2Off.Size = new System.Drawing.Size(45, 24);
            this.cam2Off.TabIndex = 17;
            this.cam2Off.Text = "OFF";
            this.cam2Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam2Off.UseVisualStyleBackColor = true;
            this.cam2Off.CheckedChanged += new System.EventHandler(this.cam2Off_CheckedChanged);
            // 
            // cam2On
            // 
            this.cam2On.Appearance = System.Windows.Forms.Appearance.Button;
            this.cam2On.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam2On.Location = new System.Drawing.Point(6, 19);
            this.cam2On.Name = "cam2On";
            this.cam2On.Size = new System.Drawing.Size(45, 24);
            this.cam2On.TabIndex = 16;
            this.cam2On.Text = "ON";
            this.cam2On.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam2On.UseVisualStyleBackColor = true;
            this.cam2On.CheckedChanged += new System.EventHandler(this.cam2On_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cam3Status);
            this.groupBox3.Controls.Add(this.cam3Auto);
            this.groupBox3.Controls.Add(this.cam3Off);
            this.groupBox3.Controls.Add(this.cam3On);
            this.groupBox3.Location = new System.Drawing.Point(199, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 52);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera 3 Power";
            // 
            // cam3Status
            // 
            this.cam3Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cam3Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cam3Status.Location = new System.Drawing.Point(143, 21);
            this.cam3Status.Name = "cam3Status";
            this.cam3Status.Size = new System.Drawing.Size(30, 20);
            this.cam3Status.TabIndex = 24;
            this.cam3Status.Text = "off";
            this.cam3Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cam3Auto
            // 
            this.cam3Auto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cam3Auto.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam3Auto.Location = new System.Drawing.Point(94, 19);
            this.cam3Auto.Name = "cam3Auto";
            this.cam3Auto.Size = new System.Drawing.Size(45, 24);
            this.cam3Auto.TabIndex = 23;
            this.cam3Auto.Text = "AUTO";
            this.cam3Auto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam3Auto.UseVisualStyleBackColor = true;
            this.cam3Auto.CheckedChanged += new System.EventHandler(this.cam3Auto_CheckedChanged);
            // 
            // cam3Off
            // 
            this.cam3Off.Appearance = System.Windows.Forms.Appearance.Button;
            this.cam3Off.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam3Off.Location = new System.Drawing.Point(50, 19);
            this.cam3Off.Name = "cam3Off";
            this.cam3Off.Size = new System.Drawing.Size(45, 24);
            this.cam3Off.TabIndex = 22;
            this.cam3Off.Text = "OFF";
            this.cam3Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam3Off.UseVisualStyleBackColor = true;
            this.cam3Off.CheckedChanged += new System.EventHandler(this.cam3Off_CheckedChanged);
            // 
            // cam3On
            // 
            this.cam3On.Appearance = System.Windows.Forms.Appearance.Button;
            this.cam3On.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam3On.Location = new System.Drawing.Point(6, 19);
            this.cam3On.Name = "cam3On";
            this.cam3On.Size = new System.Drawing.Size(45, 24);
            this.cam3On.TabIndex = 21;
            this.cam3On.Text = "ON";
            this.cam3On.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cam3On.UseVisualStyleBackColor = true;
            this.cam3On.CheckedChanged += new System.EventHandler(this.cam3On_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.selectCam3);
            this.groupBox4.Controls.Add(this.selectCam2);
            this.groupBox4.Controls.Add(this.selectCam1);
            this.groupBox4.Location = new System.Drawing.Point(199, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 52);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Handy Controller / Camera Select";
            // 
            // selectCam3
            // 
            this.selectCam3.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectCam3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectCam3.Location = new System.Drawing.Point(118, 19);
            this.selectCam3.Name = "selectCam3";
            this.selectCam3.Size = new System.Drawing.Size(55, 24);
            this.selectCam3.TabIndex = 9;
            this.selectCam3.Text = "&3";
            this.selectCam3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectCam3.UseVisualStyleBackColor = true;
            this.selectCam3.CheckedChanged += new System.EventHandler(this.selectCam3_CheckedChanged);
            // 
            // selectCam2
            // 
            this.selectCam2.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectCam2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectCam2.Location = new System.Drawing.Point(62, 19);
            this.selectCam2.Name = "selectCam2";
            this.selectCam2.Size = new System.Drawing.Size(55, 24);
            this.selectCam2.TabIndex = 8;
            this.selectCam2.Text = "&2";
            this.selectCam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectCam2.UseVisualStyleBackColor = true;
            this.selectCam2.CheckedChanged += new System.EventHandler(this.selectCam2_CheckedChanged);
            // 
            // selectCam1
            // 
            this.selectCam1.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectCam1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectCam1.Location = new System.Drawing.Point(6, 19);
            this.selectCam1.Name = "selectCam1";
            this.selectCam1.Size = new System.Drawing.Size(55, 24);
            this.selectCam1.TabIndex = 7;
            this.selectCam1.Text = "&1";
            this.selectCam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectCam1.UseVisualStyleBackColor = true;
            this.selectCam1.CheckedChanged += new System.EventHandler(this.selectCam1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OSDMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 253);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "OSDMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.OSDMenu_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OSDMenu_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private GroupBox groupBox1;
        private RadioButton cam1Auto;
        private RadioButton cam1Off;
        private RadioButton cam1On;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sensorNight;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel sensorRain;
        private GroupBox groupBox5;
        private Label cam1Status;
        private GroupBox groupBox2;
        private Label cam2Status;
        private RadioButton cam2Auto;
        private RadioButton cam2Off;
        private RadioButton cam2On;
        private GroupBox groupBox3;
        private Label cam3Status;
        private RadioButton cam3Auto;
        private RadioButton cam3Off;
        private RadioButton cam3On;
        private GroupBox groupBox4;
        private RadioButton selectCam3;
        private RadioButton selectCam2;
        private RadioButton selectCam1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem selectCOMPortToolStripMenuItem;
        private ToolStripMenuItem cOM1ToolStripMenuItem;
        private ToolStripMenuItem cOM2ToolStripMenuItem;
        private ToolStripMenuItem cOM3ToolStripMenuItem;
        private ToolStripMenuItem cOM4ToolStripMenuItem;
        private ToolStripMenuItem cOM5ToolStripMenuItem;
        private ToolStripMenuItem cOM6ToolStripMenuItem;
        private ToolStripMenuItem cOM7ToolStripMenuItem;
        private ToolStripMenuItem cOM8ToolStripMenuItem;
        private ToolStripMenuItem cOM9ToolStripMenuItem;
        private ToolStripMenuItem cOM10ToolStripMenuItem;
        private ToolStripMenuItem cOM11ToolStripMenuItem;
        private ToolStripMenuItem cOM12ToolStripMenuItem;
        private ToolStripMenuItem cOM13ToolStripMenuItem;
        private ToolStripMenuItem cOM14ToolStripMenuItem;
        private ToolStripMenuItem cOM15ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem cOM16ToolStripMenuItem;
        private Timer timer1;
        private ToolStripMenuItem saveControllerSettingsToolStripMenuItem;
        private ToolStripMenuItem cancelToolStripMenuItem;
        private ToolStripMenuItem saveNOWToolStripMenuItem;
        private ToolStripStatusLabel commStatus;
        private ToolStripMenuItem nightSensorToolStripMenuItem;
        private ToolStripMenuItem noNightToolStripMenuItem;
        private ToolStripMenuItem ncNightToolStripMenuItem;
        private ToolStripMenuItem rainSensorToolStripMenuItem;
        private ToolStripMenuItem noRainToolStripMenuItem;
        private ToolStripMenuItem ncRainToolStripMenuItem;
    }
}

