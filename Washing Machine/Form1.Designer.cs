namespace Washing_Machine
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.CB_regular = new System.Windows.Forms.Button();
            this.CB_favourite = new System.Windows.Forms.Button();
            this.CB_permanentpress = new System.Windows.Forms.Button();
            this.CB_wool = new System.Windows.Forms.Button();
            this.CB_delicate = new System.Windows.Forms.Button();
            this.CB_heavyduty = new System.Windows.Forms.Button();
            this.LB_washing_cycle = new System.Windows.Forms.Label();
            this.GB_water_level = new System.Windows.Forms.GroupBox();
            this.RB_waterlevel_low = new System.Windows.Forms.RadioButton();
            this.RB_waterlevel_medium = new System.Windows.Forms.RadioButton();
            this.RB_waterlevel_high = new System.Windows.Forms.RadioButton();
            this.RB_waterlevel_automatic = new System.Windows.Forms.RadioButton();
            this.GB_water_temperature = new System.Windows.Forms.GroupBox();
            this.RB_watertemp_cold = new System.Windows.Forms.RadioButton();
            this.RB_watertemp_warm = new System.Windows.Forms.RadioButton();
            this.RB_watertemp_hot = new System.Windows.Forms.RadioButton();
            this.GB_spin_speed = new System.Windows.Forms.GroupBox();
            this.RB_spinspeed_slow = new System.Windows.Forms.RadioButton();
            this.RB_spinspeed_medium = new System.Windows.Forms.RadioButton();
            this.RB_spinspeed_fast = new System.Windows.Forms.RadioButton();
            this.CB_on = new System.Windows.Forms.Button();
            this.CB_off = new System.Windows.Forms.Button();
            this.Animation = new System.Windows.Forms.PictureBox();
            this.CB_reset = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_timeH = new System.Windows.Forms.Label();
            this.LB_timeM = new System.Windows.Forms.Label();
            this.LB_timeS = new System.Windows.Forms.Label();
            this.LB_H = new System.Windows.Forms.Label();
            this.LB_M = new System.Windows.Forms.Label();
            this.LB_S = new System.Windows.Forms.Label();
            this.button_pause = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GB_water_level.SuspendLayout();
            this.GB_water_temperature.SuspendLayout();
            this.GB_spin_speed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_regular
            // 
            this.CB_regular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_regular.Location = new System.Drawing.Point(436, 135);
            this.CB_regular.Name = "CB_regular";
            this.CB_regular.Size = new System.Drawing.Size(117, 58);
            this.CB_regular.TabIndex = 0;
            this.CB_regular.Text = "Regular";
            this.CB_regular.UseVisualStyleBackColor = true;
            this.CB_regular.Visible = false;
            this.CB_regular.Click += new System.EventHandler(this.CB_regular_Click);
            // 
            // CB_favourite
            // 
            this.CB_favourite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_favourite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_favourite.Location = new System.Drawing.Point(562, 135);
            this.CB_favourite.Name = "CB_favourite";
            this.CB_favourite.Size = new System.Drawing.Size(117, 58);
            this.CB_favourite.TabIndex = 1;
            this.CB_favourite.Text = "Favourite";
            this.CB_favourite.UseVisualStyleBackColor = true;
            this.CB_favourite.Visible = false;
            this.CB_favourite.Click += new System.EventHandler(this.CB_favourite_Click);
            // 
            // CB_permanentpress
            // 
            this.CB_permanentpress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_permanentpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_permanentpress.Location = new System.Drawing.Point(685, 135);
            this.CB_permanentpress.Name = "CB_permanentpress";
            this.CB_permanentpress.Size = new System.Drawing.Size(125, 58);
            this.CB_permanentpress.TabIndex = 2;
            this.CB_permanentpress.Text = "Permanent Press";
            this.CB_permanentpress.UseVisualStyleBackColor = true;
            this.CB_permanentpress.Visible = false;
            this.CB_permanentpress.Click += new System.EventHandler(this.CB_permanentpress_Click);
            // 
            // CB_wool
            // 
            this.CB_wool.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_wool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_wool.Location = new System.Drawing.Point(436, 218);
            this.CB_wool.Name = "CB_wool";
            this.CB_wool.Size = new System.Drawing.Size(117, 58);
            this.CB_wool.TabIndex = 3;
            this.CB_wool.Text = "Wool";
            this.CB_wool.UseVisualStyleBackColor = true;
            this.CB_wool.Visible = false;
            this.CB_wool.Click += new System.EventHandler(this.CB_wool_Click);
            // 
            // CB_delicate
            // 
            this.CB_delicate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_delicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_delicate.Location = new System.Drawing.Point(562, 218);
            this.CB_delicate.Name = "CB_delicate";
            this.CB_delicate.Size = new System.Drawing.Size(117, 58);
            this.CB_delicate.TabIndex = 4;
            this.CB_delicate.Text = "Delicates";
            this.CB_delicate.UseVisualStyleBackColor = true;
            this.CB_delicate.Visible = false;
            this.CB_delicate.Click += new System.EventHandler(this.CB_delicate_Click);
            // 
            // CB_heavyduty
            // 
            this.CB_heavyduty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_heavyduty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_heavyduty.Location = new System.Drawing.Point(685, 218);
            this.CB_heavyduty.Name = "CB_heavyduty";
            this.CB_heavyduty.Size = new System.Drawing.Size(125, 58);
            this.CB_heavyduty.TabIndex = 5;
            this.CB_heavyduty.Text = "Heavy Duty";
            this.CB_heavyduty.UseVisualStyleBackColor = true;
            this.CB_heavyduty.Visible = false;
            this.CB_heavyduty.Click += new System.EventHandler(this.CB_heavyduty_Click);
            // 
            // LB_washing_cycle
            // 
            this.LB_washing_cycle.AutoSize = true;
            this.LB_washing_cycle.BackColor = System.Drawing.Color.Transparent;
            this.LB_washing_cycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_washing_cycle.Location = new System.Drawing.Point(558, 100);
            this.LB_washing_cycle.Name = "LB_washing_cycle";
            this.LB_washing_cycle.Size = new System.Drawing.Size(126, 20);
            this.LB_washing_cycle.TabIndex = 6;
            this.LB_washing_cycle.Text = "Washing Cycle";
            this.LB_washing_cycle.Visible = false;
            this.LB_washing_cycle.Click += new System.EventHandler(this.LB_washing_cycle_Click);
            // 
            // GB_water_level
            // 
            this.GB_water_level.Controls.Add(this.RB_waterlevel_low);
            this.GB_water_level.Controls.Add(this.RB_waterlevel_medium);
            this.GB_water_level.Controls.Add(this.RB_waterlevel_high);
            this.GB_water_level.Controls.Add(this.RB_waterlevel_automatic);
            this.GB_water_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_water_level.Location = new System.Drawing.Point(903, 317);
            this.GB_water_level.Name = "GB_water_level";
            this.GB_water_level.Size = new System.Drawing.Size(133, 201);
            this.GB_water_level.TabIndex = 7;
            this.GB_water_level.TabStop = false;
            this.GB_water_level.Text = "Water Level";
            this.GB_water_level.Visible = false;
            this.GB_water_level.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RB_waterlevel_low
            // 
            this.RB_waterlevel_low.AutoSize = true;
            this.RB_waterlevel_low.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_waterlevel_low.Location = new System.Drawing.Point(18, 174);
            this.RB_waterlevel_low.Name = "RB_waterlevel_low";
            this.RB_waterlevel_low.Size = new System.Drawing.Size(56, 24);
            this.RB_waterlevel_low.TabIndex = 3;
            this.RB_waterlevel_low.TabStop = true;
            this.RB_waterlevel_low.Text = "Low";
            this.RB_waterlevel_low.UseVisualStyleBackColor = true;
            // 
            // RB_waterlevel_medium
            // 
            this.RB_waterlevel_medium.AutoSize = true;
            this.RB_waterlevel_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_waterlevel_medium.Location = new System.Drawing.Point(18, 126);
            this.RB_waterlevel_medium.Name = "RB_waterlevel_medium";
            this.RB_waterlevel_medium.Size = new System.Drawing.Size(83, 24);
            this.RB_waterlevel_medium.TabIndex = 2;
            this.RB_waterlevel_medium.TabStop = true;
            this.RB_waterlevel_medium.Text = "Medium";
            this.RB_waterlevel_medium.UseVisualStyleBackColor = true;
            // 
            // RB_waterlevel_high
            // 
            this.RB_waterlevel_high.AutoSize = true;
            this.RB_waterlevel_high.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_waterlevel_high.Location = new System.Drawing.Point(18, 78);
            this.RB_waterlevel_high.Name = "RB_waterlevel_high";
            this.RB_waterlevel_high.Size = new System.Drawing.Size(60, 24);
            this.RB_waterlevel_high.TabIndex = 1;
            this.RB_waterlevel_high.TabStop = true;
            this.RB_waterlevel_high.Text = "High";
            this.RB_waterlevel_high.UseVisualStyleBackColor = true;
            // 
            // RB_waterlevel_automatic
            // 
            this.RB_waterlevel_automatic.AutoSize = true;
            this.RB_waterlevel_automatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_waterlevel_automatic.Location = new System.Drawing.Point(18, 37);
            this.RB_waterlevel_automatic.Name = "RB_waterlevel_automatic";
            this.RB_waterlevel_automatic.Size = new System.Drawing.Size(99, 24);
            this.RB_waterlevel_automatic.TabIndex = 0;
            this.RB_waterlevel_automatic.TabStop = true;
            this.RB_waterlevel_automatic.Text = "Automatic";
            this.RB_waterlevel_automatic.UseVisualStyleBackColor = true;
            this.RB_waterlevel_automatic.CheckedChanged += new System.EventHandler(this.RB_waterlevel_automatic_CheckedChanged);
            // 
            // GB_water_temperature
            // 
            this.GB_water_temperature.Controls.Add(this.RB_watertemp_cold);
            this.GB_water_temperature.Controls.Add(this.RB_watertemp_warm);
            this.GB_water_temperature.Controls.Add(this.RB_watertemp_hot);
            this.GB_water_temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_water_temperature.Location = new System.Drawing.Point(829, 126);
            this.GB_water_temperature.Name = "GB_water_temperature";
            this.GB_water_temperature.Size = new System.Drawing.Size(133, 178);
            this.GB_water_temperature.TabIndex = 8;
            this.GB_water_temperature.TabStop = false;
            this.GB_water_temperature.Text = "Water Temperature";
            this.GB_water_temperature.Visible = false;
            this.GB_water_temperature.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // RB_watertemp_cold
            // 
            this.RB_watertemp_cold.AutoSize = true;
            this.RB_watertemp_cold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_watertemp_cold.Location = new System.Drawing.Point(18, 137);
            this.RB_watertemp_cold.Name = "RB_watertemp_cold";
            this.RB_watertemp_cold.Size = new System.Drawing.Size(59, 24);
            this.RB_watertemp_cold.TabIndex = 2;
            this.RB_watertemp_cold.TabStop = true;
            this.RB_watertemp_cold.Text = "Cold";
            this.RB_watertemp_cold.UseVisualStyleBackColor = true;
            // 
            // RB_watertemp_warm
            // 
            this.RB_watertemp_warm.AutoSize = true;
            this.RB_watertemp_warm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_watertemp_warm.Location = new System.Drawing.Point(18, 92);
            this.RB_watertemp_warm.Name = "RB_watertemp_warm";
            this.RB_watertemp_warm.Size = new System.Drawing.Size(69, 24);
            this.RB_watertemp_warm.TabIndex = 1;
            this.RB_watertemp_warm.TabStop = true;
            this.RB_watertemp_warm.Text = "Warm";
            this.RB_watertemp_warm.UseVisualStyleBackColor = true;
            // 
            // RB_watertemp_hot
            // 
            this.RB_watertemp_hot.AutoSize = true;
            this.RB_watertemp_hot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_watertemp_hot.Location = new System.Drawing.Point(18, 50);
            this.RB_watertemp_hot.Name = "RB_watertemp_hot";
            this.RB_watertemp_hot.Size = new System.Drawing.Size(53, 24);
            this.RB_watertemp_hot.TabIndex = 0;
            this.RB_watertemp_hot.TabStop = true;
            this.RB_watertemp_hot.Text = "Hot";
            this.RB_watertemp_hot.UseVisualStyleBackColor = true;
            // 
            // GB_spin_speed
            // 
            this.GB_spin_speed.Controls.Add(this.RB_spinspeed_slow);
            this.GB_spin_speed.Controls.Add(this.RB_spinspeed_medium);
            this.GB_spin_speed.Controls.Add(this.RB_spinspeed_fast);
            this.GB_spin_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_spin_speed.Location = new System.Drawing.Point(979, 126);
            this.GB_spin_speed.Name = "GB_spin_speed";
            this.GB_spin_speed.Size = new System.Drawing.Size(133, 178);
            this.GB_spin_speed.TabIndex = 9;
            this.GB_spin_speed.TabStop = false;
            this.GB_spin_speed.Text = "Spin Speed";
            this.GB_spin_speed.Visible = false;
            // 
            // RB_spinspeed_slow
            // 
            this.RB_spinspeed_slow.AutoSize = true;
            this.RB_spinspeed_slow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_spinspeed_slow.Location = new System.Drawing.Point(18, 137);
            this.RB_spinspeed_slow.Name = "RB_spinspeed_slow";
            this.RB_spinspeed_slow.Size = new System.Drawing.Size(61, 24);
            this.RB_spinspeed_slow.TabIndex = 2;
            this.RB_spinspeed_slow.TabStop = true;
            this.RB_spinspeed_slow.Text = "Slow";
            this.RB_spinspeed_slow.UseVisualStyleBackColor = true;
            // 
            // RB_spinspeed_medium
            // 
            this.RB_spinspeed_medium.AutoSize = true;
            this.RB_spinspeed_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_spinspeed_medium.Location = new System.Drawing.Point(18, 92);
            this.RB_spinspeed_medium.Name = "RB_spinspeed_medium";
            this.RB_spinspeed_medium.Size = new System.Drawing.Size(83, 24);
            this.RB_spinspeed_medium.TabIndex = 1;
            this.RB_spinspeed_medium.TabStop = true;
            this.RB_spinspeed_medium.Text = "Medium";
            this.RB_spinspeed_medium.UseVisualStyleBackColor = true;
            // 
            // RB_spinspeed_fast
            // 
            this.RB_spinspeed_fast.AutoSize = true;
            this.RB_spinspeed_fast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_spinspeed_fast.Location = new System.Drawing.Point(18, 50);
            this.RB_spinspeed_fast.Name = "RB_spinspeed_fast";
            this.RB_spinspeed_fast.Size = new System.Drawing.Size(59, 24);
            this.RB_spinspeed_fast.TabIndex = 0;
            this.RB_spinspeed_fast.TabStop = true;
            this.RB_spinspeed_fast.Text = "Fast";
            this.RB_spinspeed_fast.UseVisualStyleBackColor = true;
            // 
            // CB_on
            // 
            this.CB_on.BackColor = System.Drawing.Color.Transparent;
            this.CB_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB_on.BackgroundImage")));
            this.CB_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB_on.FlatAppearance.BorderSize = 0;
            this.CB_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_on.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CB_on.Location = new System.Drawing.Point(147, 18);
            this.CB_on.Name = "CB_on";
            this.CB_on.Size = new System.Drawing.Size(94, 96);
            this.CB_on.TabIndex = 10;
            this.CB_on.UseVisualStyleBackColor = false;
            this.CB_on.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_off
            // 
            this.CB_off.BackColor = System.Drawing.Color.Transparent;
            this.CB_off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB_off.BackgroundImage")));
            this.CB_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB_off.FlatAppearance.BorderSize = 0;
            this.CB_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_off.Location = new System.Drawing.Point(27, 12);
            this.CB_off.Name = "CB_off";
            this.CB_off.Size = new System.Drawing.Size(114, 108);
            this.CB_off.TabIndex = 11;
            this.CB_off.UseVisualStyleBackColor = false;
            this.CB_off.Click += new System.EventHandler(this.CB_off_Click);
            // 
            // Animation
            // 
            this.Animation.Image = ((System.Drawing.Image)(resources.GetObject("Animation.Image")));
            this.Animation.Location = new System.Drawing.Point(15, 96);
            this.Animation.Name = "Animation";
            this.Animation.Size = new System.Drawing.Size(389, 254);
            this.Animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Animation.TabIndex = 12;
            this.Animation.TabStop = false;
            this.Animation.Visible = false;
            this.Animation.Click += new System.EventHandler(this.Animation_Click);
            // 
            // CB_reset
            // 
            this.CB_reset.BackColor = System.Drawing.Color.Transparent;
            this.CB_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB_reset.BackgroundImage")));
            this.CB_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB_reset.FlatAppearance.BorderSize = 0;
            this.CB_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_reset.Location = new System.Drawing.Point(577, 395);
            this.CB_reset.Name = "CB_reset";
            this.CB_reset.Size = new System.Drawing.Size(107, 103);
            this.CB_reset.TabIndex = 13;
            this.CB_reset.UseVisualStyleBackColor = false;
            this.CB_reset.Visible = false;
            this.CB_reset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Transparent;
            this.button_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_start.BackgroundImage")));
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_start.FlatAppearance.BorderSize = 0;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(479, 298);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(103, 97);
            this.button_start.TabIndex = 14;
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Visible = false;
            this.button_start.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LB_timeH
            // 
            this.LB_timeH.AutoSize = true;
            this.LB_timeH.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_timeH.ForeColor = System.Drawing.Color.White;
            this.LB_timeH.Location = new System.Drawing.Point(145, 41);
            this.LB_timeH.Name = "LB_timeH";
            this.LB_timeH.Size = new System.Drawing.Size(40, 42);
            this.LB_timeH.TabIndex = 15;
            this.LB_timeH.Text = "00";
            this.LB_timeH.Visible = false;
            this.LB_timeH.Click += new System.EventHandler(this.H_Click);
            // 
            // LB_timeM
            // 
            this.LB_timeM.AutoSize = true;
            this.LB_timeM.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_timeM.ForeColor = System.Drawing.Color.White;
            this.LB_timeM.Location = new System.Drawing.Point(198, 41);
            this.LB_timeM.Name = "LB_timeM";
            this.LB_timeM.Size = new System.Drawing.Size(40, 42);
            this.LB_timeM.TabIndex = 16;
            this.LB_timeM.Text = "00";
            this.LB_timeM.Visible = false;
            // 
            // LB_timeS
            // 
            this.LB_timeS.AutoSize = true;
            this.LB_timeS.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_timeS.ForeColor = System.Drawing.Color.White;
            this.LB_timeS.Location = new System.Drawing.Point(252, 41);
            this.LB_timeS.Name = "LB_timeS";
            this.LB_timeS.Size = new System.Drawing.Size(40, 42);
            this.LB_timeS.TabIndex = 17;
            this.LB_timeS.Text = "00";
            this.LB_timeS.Visible = false;
            // 
            // LB_H
            // 
            this.LB_H.AutoSize = true;
            this.LB_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_H.ForeColor = System.Drawing.Color.White;
            this.LB_H.Location = new System.Drawing.Point(163, 64);
            this.LB_H.Name = "LB_H";
            this.LB_H.Size = new System.Drawing.Size(0, 29);
            this.LB_H.TabIndex = 18;
            this.LB_H.Visible = false;
            // 
            // LB_M
            // 
            this.LB_M.AutoSize = true;
            this.LB_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_M.ForeColor = System.Drawing.Color.White;
            this.LB_M.Location = new System.Drawing.Point(216, 64);
            this.LB_M.Name = "LB_M";
            this.LB_M.Size = new System.Drawing.Size(0, 29);
            this.LB_M.TabIndex = 19;
            this.LB_M.Visible = false;
            // 
            // LB_S
            // 
            this.LB_S.AutoSize = true;
            this.LB_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_S.ForeColor = System.Drawing.Color.White;
            this.LB_S.Location = new System.Drawing.Point(271, 64);
            this.LB_S.Name = "LB_S";
            this.LB_S.Size = new System.Drawing.Size(0, 29);
            this.LB_S.TabIndex = 20;
            this.LB_S.Visible = false;
            // 
            // button_pause
            // 
            this.button_pause.BackColor = System.Drawing.Color.Transparent;
            this.button_pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_pause.BackgroundImage")));
            this.button_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pause.FlatAppearance.BorderSize = 0;
            this.button_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pause.Location = new System.Drawing.Point(673, 294);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(108, 104);
            this.button_pause.TabIndex = 21;
            this.button_pause.UseVisualStyleBackColor = false;
            this.button_pause.Visible = false;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.Location = new System.Drawing.Point(888, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 25, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LB_S);
            this.panel1.Controls.Add(this.LB_M);
            this.panel1.Controls.Add(this.LB_H);
            this.panel1.Controls.Add(this.LB_timeS);
            this.panel1.Controls.Add(this.LB_timeM);
            this.panel1.Controls.Add(this.Animation);
            this.panel1.Controls.Add(this.LB_timeH);
            this.panel1.Location = new System.Drawing.Point(12, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 363);
            this.panel1.TabIndex = 23;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.GB_water_level);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.CB_reset);
            this.Controls.Add(this.CB_off);
            this.Controls.Add(this.CB_on);
            this.Controls.Add(this.GB_spin_speed);
            this.Controls.Add(this.GB_water_temperature);
            this.Controls.Add(this.LB_washing_cycle);
            this.Controls.Add(this.CB_heavyduty);
            this.Controls.Add(this.CB_delicate);
            this.Controls.Add(this.CB_wool);
            this.Controls.Add(this.CB_permanentpress);
            this.Controls.Add(this.CB_favourite);
            this.Controls.Add(this.CB_regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WM";
            this.Load += new System.EventHandler(this.WM_Load);
            this.GB_water_level.ResumeLayout(false);
            this.GB_water_level.PerformLayout();
            this.GB_water_temperature.ResumeLayout(false);
            this.GB_water_temperature.PerformLayout();
            this.GB_spin_speed.ResumeLayout(false);
            this.GB_spin_speed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CB_regular;
        private System.Windows.Forms.Button CB_favourite;
        private System.Windows.Forms.Button CB_permanentpress;
        private System.Windows.Forms.Button CB_wool;
        private System.Windows.Forms.Button CB_delicate;
        private System.Windows.Forms.Button CB_heavyduty;
        private System.Windows.Forms.Label LB_washing_cycle;
        private System.Windows.Forms.GroupBox GB_water_level;
        private System.Windows.Forms.RadioButton RB_waterlevel_low;
        private System.Windows.Forms.RadioButton RB_waterlevel_medium;
        private System.Windows.Forms.RadioButton RB_waterlevel_high;
        private System.Windows.Forms.RadioButton RB_waterlevel_automatic;
        private System.Windows.Forms.GroupBox GB_water_temperature;
        private System.Windows.Forms.RadioButton RB_watertemp_cold;
        private System.Windows.Forms.RadioButton RB_watertemp_warm;
        private System.Windows.Forms.RadioButton RB_watertemp_hot;
        private System.Windows.Forms.GroupBox GB_spin_speed;
        private System.Windows.Forms.RadioButton RB_spinspeed_slow;
        private System.Windows.Forms.RadioButton RB_spinspeed_medium;
        private System.Windows.Forms.RadioButton RB_spinspeed_fast;
        private System.Windows.Forms.Button CB_on;
        private System.Windows.Forms.Button CB_off;
        private System.Windows.Forms.PictureBox Animation;
        private System.Windows.Forms.Button CB_reset;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_timeH;
        private System.Windows.Forms.Label LB_timeM;
        private System.Windows.Forms.Label LB_timeS;
        private System.Windows.Forms.Label LB_H;
        private System.Windows.Forms.Label LB_M;
        private System.Windows.Forms.Label LB_S;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
    }
}

