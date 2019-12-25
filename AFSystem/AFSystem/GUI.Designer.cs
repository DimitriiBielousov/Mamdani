namespace AF_System
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.lblLogoText = new ns1.BunifuCustomLabel();
            this.btnMinimized = new ns1.BunifuImageButton();
            this.btnClose = new ns1.BunifuImageButton();
            this.imgLogo = new ns1.BunifuImageButton();
            this.lblname = new ns1.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_AnglePlus = new ns1.BunifuTrackbar();
            this.imgAnglePlus = new ns1.BunifuImageButton();
            this.TB_AngleMin = new ns1.BunifuTrackbar();
            this.imgAngleMin = new ns1.BunifuImageButton();
            this.TB_Distance = new ns1.BunifuTrackbar();
            this.imgDistance = new ns1.BunifuImageButton();
            this.TB_Speed = new ns1.BunifuTrackbar();
            this.imgSpeed = new ns1.BunifuImageButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblvalueBrake = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new ns1.BunifuCustomLabel();
            this.lblvalueAngle = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.lblvalueDistance = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.lblvalueSpeed = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.lblAngle = new ns1.BunifuCustomLabel();
            this.lblDistance = new ns1.BunifuCustomLabel();
            this.bunifuImageButton4 = new ns1.BunifuImageButton();
            this.bunifuImageButton12 = new ns1.BunifuImageButton();
            this.Gauge_Angle = new ns1.BunifuGauge();
            this.Gauge_Distance = new ns1.BunifuGauge();
            this.lblBrake = new ns1.BunifuCustomLabel();
            this.lblSpeed = new ns1.BunifuCustomLabel();
            this.bunifuImageButton10 = new ns1.BunifuImageButton();
            this.bunifuImageButton9 = new ns1.BunifuImageButton();
            this.Gauge_Break = new ns1.BunifuGauge();
            this.Gauge_Speed = new ns1.BunifuGauge();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imgCars = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnglePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAngleMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCars)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Navy;
            this.header.Controls.Add(this.lblLogoText);
            this.header.Controls.Add(this.btnMinimized);
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.imgLogo);
            this.header.Controls.Add(this.lblname);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(916, 43);
            this.header.TabIndex = 0;
            // 
            // lblLogoText
            // 
            this.lblLogoText.AutoSize = true;
            this.lblLogoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLogoText.ForeColor = System.Drawing.Color.White;
            this.lblLogoText.Location = new System.Drawing.Point(156, 11);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(62, 20);
            this.lblLogoText.TabIndex = 7;
            this.lblLogoText.Text = "System";
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = null;
            this.btnMinimized.Location = new System.Drawing.Point(835, -4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 63);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 6;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.bunifuImageButton8_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(872, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.bunifuImageButton7_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.ImageActive = null;
            this.imgLogo.Location = new System.Drawing.Point(7, -1);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(50, 43);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 4;
            this.imgLogo.TabStop = false;
            this.imgLogo.Zoom = 0;
            this.imgLogo.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(58, 11);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(94, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "FuzzySmart";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.TB_AnglePlus);
            this.panel2.Controls.Add(this.imgAnglePlus);
            this.panel2.Controls.Add(this.TB_AngleMin);
            this.panel2.Controls.Add(this.imgAngleMin);
            this.panel2.Controls.Add(this.TB_Distance);
            this.panel2.Controls.Add(this.imgDistance);
            this.panel2.Controls.Add(this.TB_Speed);
            this.panel2.Controls.Add(this.imgSpeed);
            this.panel2.Location = new System.Drawing.Point(552, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 268);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // TB_AnglePlus
            // 
            this.TB_AnglePlus.BackColor = System.Drawing.Color.Transparent;
            this.TB_AnglePlus.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.TB_AnglePlus.BorderRadius = 0;
            this.TB_AnglePlus.IndicatorColor = System.Drawing.Color.Purple;
            this.TB_AnglePlus.Location = new System.Drawing.Point(57, 202);
            this.TB_AnglePlus.MaximumValue = 90;
            this.TB_AnglePlus.Name = "TB_AnglePlus";
            this.TB_AnglePlus.Size = new System.Drawing.Size(295, 30);
            this.TB_AnglePlus.SliderRadius = 5;
            this.TB_AnglePlus.TabIndex = 5;
            this.TB_AnglePlus.Value = 0;
            this.TB_AnglePlus.ValueChanged += new System.EventHandler(this.TB_AnglePlus_ValueChanged);
            // 
            // imgAnglePlus
            // 
            this.imgAnglePlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.imgAnglePlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAnglePlus.Image = ((System.Drawing.Image)(resources.GetObject("imgAnglePlus.Image")));
            this.imgAnglePlus.ImageActive = null;
            this.imgAnglePlus.Location = new System.Drawing.Point(12, 197);
            this.imgAnglePlus.Name = "imgAnglePlus";
            this.imgAnglePlus.Size = new System.Drawing.Size(25, 25);
            this.imgAnglePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAnglePlus.TabIndex = 6;
            this.imgAnglePlus.TabStop = false;
            this.imgAnglePlus.Zoom = 10;
            // 
            // TB_AngleMin
            // 
            this.TB_AngleMin.BackColor = System.Drawing.Color.Transparent;
            this.TB_AngleMin.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.TB_AngleMin.BorderRadius = 0;
            this.TB_AngleMin.IndicatorColor = System.Drawing.Color.Purple;
            this.TB_AngleMin.Location = new System.Drawing.Point(57, 145);
            this.TB_AngleMin.MaximumValue = 90;
            this.TB_AngleMin.Name = "TB_AngleMin";
            this.TB_AngleMin.Size = new System.Drawing.Size(295, 30);
            this.TB_AngleMin.SliderRadius = 5;
            this.TB_AngleMin.TabIndex = 4;
            this.TB_AngleMin.Value = 0;
            this.TB_AngleMin.ValueChanged += new System.EventHandler(this.TB_AngleMin_ValueChanged);
            // 
            // imgAngleMin
            // 
            this.imgAngleMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.imgAngleMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAngleMin.Image = ((System.Drawing.Image)(resources.GetObject("imgAngleMin.Image")));
            this.imgAngleMin.ImageActive = null;
            this.imgAngleMin.Location = new System.Drawing.Point(12, 143);
            this.imgAngleMin.Name = "imgAngleMin";
            this.imgAngleMin.Size = new System.Drawing.Size(25, 25);
            this.imgAngleMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAngleMin.TabIndex = 5;
            this.imgAngleMin.TabStop = false;
            this.imgAngleMin.Zoom = 10;
            // 
            // TB_Distance
            // 
            this.TB_Distance.BackColor = System.Drawing.Color.Transparent;
            this.TB_Distance.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.TB_Distance.BorderRadius = 0;
            this.TB_Distance.IndicatorColor = System.Drawing.Color.Purple;
            this.TB_Distance.Location = new System.Drawing.Point(57, 89);
            this.TB_Distance.MaximumValue = 10;
            this.TB_Distance.Name = "TB_Distance";
            this.TB_Distance.Size = new System.Drawing.Size(295, 30);
            this.TB_Distance.SliderRadius = 5;
            this.TB_Distance.TabIndex = 3;
            this.TB_Distance.Value = 0;
            this.TB_Distance.ValueChanged += new System.EventHandler(this.TB_Distance_ValueChanged);
            // 
            // imgDistance
            // 
            this.imgDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.imgDistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDistance.Image = ((System.Drawing.Image)(resources.GetObject("imgDistance.Image")));
            this.imgDistance.ImageActive = null;
            this.imgDistance.Location = new System.Drawing.Point(12, 89);
            this.imgDistance.Name = "imgDistance";
            this.imgDistance.Size = new System.Drawing.Size(25, 25);
            this.imgDistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDistance.TabIndex = 4;
            this.imgDistance.TabStop = false;
            this.imgDistance.Zoom = 10;
            // 
            // TB_Speed
            // 
            this.TB_Speed.BackColor = System.Drawing.Color.Transparent;
            this.TB_Speed.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.TB_Speed.BorderRadius = 0;
            this.TB_Speed.IndicatorColor = System.Drawing.Color.Purple;
            this.TB_Speed.Location = new System.Drawing.Point(57, 33);
            this.TB_Speed.MaximumValue = 120;
            this.TB_Speed.Name = "TB_Speed";
            this.TB_Speed.Size = new System.Drawing.Size(295, 30);
            this.TB_Speed.SliderRadius = 5;
            this.TB_Speed.TabIndex = 2;
            this.TB_Speed.Value = 0;
            this.TB_Speed.ValueChanged += new System.EventHandler(this.TB_Speed_ValueChanged);
            this.TB_Speed.MouseCaptureChanged += new System.EventHandler(this.TB_Speed_MouseCaptureChanged);
            // 
            // imgSpeed
            // 
            this.imgSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.imgSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSpeed.Image = ((System.Drawing.Image)(resources.GetObject("imgSpeed.Image")));
            this.imgSpeed.ImageActive = null;
            this.imgSpeed.Location = new System.Drawing.Point(12, 34);
            this.imgSpeed.Name = "imgSpeed";
            this.imgSpeed.Size = new System.Drawing.Size(25, 25);
            this.imgSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSpeed.TabIndex = 3;
            this.imgSpeed.TabStop = false;
            this.imgSpeed.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblvalueBrake);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.lblvalueAngle);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.lblvalueDistance);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.lblvalueSpeed);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.lblAngle);
            this.panel1.Controls.Add(this.lblDistance);
            this.panel1.Controls.Add(this.bunifuImageButton4);
            this.panel1.Controls.Add(this.bunifuImageButton12);
            this.panel1.Controls.Add(this.Gauge_Angle);
            this.panel1.Controls.Add(this.Gauge_Distance);
            this.panel1.Controls.Add(this.lblBrake);
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.bunifuImageButton10);
            this.panel1.Controls.Add(this.bunifuImageButton9);
            this.panel1.Controls.Add(this.Gauge_Break);
            this.panel1.Controls.Add(this.Gauge_Speed);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 529);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblvalueBrake
            // 
            this.lblvalueBrake.AutoSize = true;
            this.lblvalueBrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalueBrake.ForeColor = System.Drawing.Color.Gray;
            this.lblvalueBrake.Location = new System.Drawing.Point(381, 141);
            this.lblvalueBrake.Name = "lblvalueBrake";
            this.lblvalueBrake.Size = new System.Drawing.Size(18, 20);
            this.lblvalueBrake.TabIndex = 29;
            this.lblvalueBrake.Text = "0";
            this.lblvalueBrake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(219, 415);
            this.bunifuCustomLabel11.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(22, 17);
            this.bunifuCustomLabel11.TabIndex = 28;
            this.bunifuCustomLabel11.Text = "10";
            // 
            // lblvalueAngle
            // 
            this.lblvalueAngle.AutoSize = true;
            this.lblvalueAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblvalueAngle.ForeColor = System.Drawing.Color.Gray;
            this.lblvalueAngle.Location = new System.Drawing.Point(380, 358);
            this.lblvalueAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalueAngle.Name = "lblvalueAngle";
            this.lblvalueAngle.Size = new System.Drawing.Size(22, 18);
            this.lblvalueAngle.TabIndex = 8;
            this.lblvalueAngle.Text = "0°";
            this.lblvalueAngle.Click += new System.EventHandler(this.Value_AngleMin_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(466, 417);
            this.bunifuCustomLabel10.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(43, 17);
            this.bunifuCustomLabel10.TabIndex = 27;
            this.bunifuCustomLabel10.Text = "± 90 °";
            // 
            // lblvalueDistance
            // 
            this.lblvalueDistance.AutoSize = true;
            this.lblvalueDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblvalueDistance.ForeColor = System.Drawing.Color.Gray;
            this.lblvalueDistance.Location = new System.Drawing.Point(119, 358);
            this.lblvalueDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalueDistance.Name = "lblvalueDistance";
            this.lblvalueDistance.Size = new System.Drawing.Size(33, 18);
            this.lblvalueDistance.TabIndex = 7;
            this.lblvalueDistance.Text = "0 m";
            this.lblvalueDistance.Click += new System.EventHandler(this.Value_Distance_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(470, 201);
            this.bunifuCustomLabel9.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(22, 17);
            this.bunifuCustomLabel9.TabIndex = 26;
            this.bunifuCustomLabel9.Text = "10";
            // 
            // lblvalueSpeed
            // 
            this.lblvalueSpeed.AutoSize = true;
            this.lblvalueSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblvalueSpeed.ForeColor = System.Drawing.Color.Gray;
            this.lblvalueSpeed.Location = new System.Drawing.Point(108, 141);
            this.lblvalueSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalueSpeed.Name = "lblvalueSpeed";
            this.lblvalueSpeed.Size = new System.Drawing.Size(55, 18);
            this.lblvalueSpeed.TabIndex = 6;
            this.lblvalueSpeed.Text = "0 Km/h";
            this.lblvalueSpeed.Click += new System.EventHandler(this.Value_Speed_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(216, 201);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(29, 17);
            this.bunifuCustomLabel8.TabIndex = 25;
            this.bunifuCustomLabel8.Text = "120";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngle.ForeColor = System.Drawing.Color.Gray;
            this.lblAngle.Location = new System.Drawing.Point(371, 420);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(50, 20);
            this.lblAngle.TabIndex = 24;
            this.lblAngle.Text = "Angle";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.ForeColor = System.Drawing.Color.Gray;
            this.lblDistance.Location = new System.Drawing.Point(101, 422);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(72, 20);
            this.lblDistance.TabIndex = 23;
            this.lblDistance.Text = "Distance";
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(97, 381);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(80, 38);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 22;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 0;
            // 
            // bunifuImageButton12
            // 
            this.bunifuImageButton12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton12.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton12.Image")));
            this.bunifuImageButton12.ImageActive = null;
            this.bunifuImageButton12.Location = new System.Drawing.Point(355, 381);
            this.bunifuImageButton12.Name = "bunifuImageButton12";
            this.bunifuImageButton12.Size = new System.Drawing.Size(80, 38);
            this.bunifuImageButton12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton12.TabIndex = 21;
            this.bunifuImageButton12.TabStop = false;
            this.bunifuImageButton12.Zoom = 0;
            // 
            // Gauge_Angle
            // 
            this.Gauge_Angle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Gauge_Angle.BackgroundImage")));
            this.Gauge_Angle.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Gauge_Angle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(142)))));
            this.Gauge_Angle.Location = new System.Drawing.Point(265, 265);
            this.Gauge_Angle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gauge_Angle.Name = "Gauge_Angle";
            this.Gauge_Angle.ProgressBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.Gauge_Angle.ProgressColor1 = System.Drawing.Color.Crimson;
            this.Gauge_Angle.ProgressColor2 = System.Drawing.Color.Red;
            this.Gauge_Angle.Size = new System.Drawing.Size(248, 180);
            this.Gauge_Angle.TabIndex = 20;
            this.Gauge_Angle.Thickness = 40;
            this.Gauge_Angle.Value = 0;
            // 
            // Gauge_Distance
            // 
            this.Gauge_Distance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Gauge_Distance.BackgroundImage")));
            this.Gauge_Distance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Gauge_Distance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(142)))));
            this.Gauge_Distance.Location = new System.Drawing.Point(14, 265);
            this.Gauge_Distance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gauge_Distance.Name = "Gauge_Distance";
            this.Gauge_Distance.ProgressBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.Gauge_Distance.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.Gauge_Distance.ProgressColor2 = System.Drawing.Color.Red;
            this.Gauge_Distance.Size = new System.Drawing.Size(248, 180);
            this.Gauge_Distance.TabIndex = 19;
            this.Gauge_Distance.Thickness = 40;
            this.Gauge_Distance.Value = 0;
            // 
            // lblBrake
            // 
            this.lblBrake.AutoSize = true;
            this.lblBrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrake.ForeColor = System.Drawing.Color.Gray;
            this.lblBrake.Location = new System.Drawing.Point(365, 205);
            this.lblBrake.Name = "lblBrake";
            this.lblBrake.Size = new System.Drawing.Size(51, 20);
            this.lblBrake.TabIndex = 18;
            this.lblBrake.Text = "Brake";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.Gray;
            this.lblSpeed.Location = new System.Drawing.Point(111, 205);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(56, 20);
            this.lblSpeed.TabIndex = 17;
            this.lblSpeed.Text = "Speed";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSpeed.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuImageButton10
            // 
            this.bunifuImageButton10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton10.Image")));
            this.bunifuImageButton10.ImageActive = null;
            this.bunifuImageButton10.Location = new System.Drawing.Point(97, 164);
            this.bunifuImageButton10.Name = "bunifuImageButton10";
            this.bunifuImageButton10.Size = new System.Drawing.Size(80, 38);
            this.bunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton10.TabIndex = 9;
            this.bunifuImageButton10.TabStop = false;
            this.bunifuImageButton10.Zoom = 0;
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(350, 165);
            this.bunifuImageButton9.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(80, 38);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 8;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuImageButton9.Zoom = 10;
            this.bunifuImageButton9.Click += new System.EventHandler(this.bunifuImageButton9_Click);
            // 
            // Gauge_Break
            // 
            this.Gauge_Break.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Gauge_Break.BackgroundImage")));
            this.Gauge_Break.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Gauge_Break.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(142)))));
            this.Gauge_Break.Location = new System.Drawing.Point(265, 48);
            this.Gauge_Break.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gauge_Break.Name = "Gauge_Break";
            this.Gauge_Break.ProgressBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.Gauge_Break.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.Gauge_Break.ProgressColor2 = System.Drawing.Color.Red;
            this.Gauge_Break.Size = new System.Drawing.Size(248, 180);
            this.Gauge_Break.TabIndex = 1;
            this.Gauge_Break.Thickness = 40;
            this.Gauge_Break.Value = 0;
            this.Gauge_Break.Load += new System.EventHandler(this.Gauge_Break_Load);
            // 
            // Gauge_Speed
            // 
            this.Gauge_Speed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Gauge_Speed.BackgroundImage")));
            this.Gauge_Speed.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Gauge_Speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(142)))));
            this.Gauge_Speed.Location = new System.Drawing.Point(14, 48);
            this.Gauge_Speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gauge_Speed.Name = "Gauge_Speed";
            this.Gauge_Speed.ProgressBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.Gauge_Speed.ProgressColor1 = System.Drawing.SystemColors.HotTrack;
            this.Gauge_Speed.ProgressColor2 = System.Drawing.Color.Red;
            this.Gauge_Speed.Size = new System.Drawing.Size(248, 180);
            this.Gauge_Speed.TabIndex = 0;
            this.Gauge_Speed.Thickness = 40;
            this.Gauge_Speed.Value = 0;
            this.Gauge_Speed.Load += new System.EventHandler(this.bunifuGauge1_Load);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.imgCars);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 522);
            this.panel3.TabIndex = 2;
            // 
            // imgCars
            // 
            this.imgCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.imgCars.Image = ((System.Drawing.Image)(resources.GetObject("imgCars.Image")));
            this.imgCars.Location = new System.Drawing.Point(552, 269);
            this.imgCars.Name = "imgCars";
            this.imgCars.Size = new System.Drawing.Size(364, 241);
            this.imgCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCars.TabIndex = 13;
            this.imgCars.TabStop = false;
            this.imgCars.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 565);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAnglePlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAngleMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCars)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel header;
        private ns1.BunifuCustomLabel lblname;
        private ns1.BunifuImageButton imgAnglePlus;
        private ns1.BunifuImageButton imgAngleMin;
        private ns1.BunifuImageButton imgDistance;
        private ns1.BunifuImageButton imgSpeed;
        private ns1.BunifuImageButton btnMinimized;
        private ns1.BunifuImageButton btnClose;
        private ns1.BunifuImageButton imgLogo;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuElipse bunifuElipse2;
        private ns1.BunifuCustomLabel lblLogoText;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuTrackbar TB_AnglePlus;
        private ns1.BunifuTrackbar TB_AngleMin;
        private ns1.BunifuTrackbar TB_Distance;
        private ns1.BunifuTrackbar TB_Speed;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuGauge Gauge_Break;
        private ns1.BunifuGauge Gauge_Speed;
        private ns1.BunifuCustomLabel lblBrake;
        private ns1.BunifuCustomLabel lblSpeed;
        private ns1.BunifuImageButton bunifuImageButton10;
        private ns1.BunifuImageButton bunifuImageButton9;
        private ns1.BunifuCustomLabel lblAngle;
        private ns1.BunifuCustomLabel lblDistance;
        private ns1.BunifuImageButton bunifuImageButton4;
        private ns1.BunifuImageButton bunifuImageButton12;
        private ns1.BunifuGauge Gauge_Angle;
        private ns1.BunifuGauge Gauge_Distance;
        private ns1.BunifuCustomLabel lblvalueSpeed;
        private ns1.BunifuCustomLabel lblvalueAngle;
        private ns1.BunifuCustomLabel lblvalueDistance;
        private ns1.BunifuCustomLabel bunifuCustomLabel11;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.PictureBox imgCars;
        private ns1.BunifuCustomLabel lblvalueBrake;
    }
}

