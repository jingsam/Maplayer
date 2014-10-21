namespace MapPlayer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPause = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLegend = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLegend = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.btn10 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn9 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtGeneration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFitness = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.graph = new ZedGraph.ZedGraphControl();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.menu.SuspendLayout();
            this.grpLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zedGraphControl1.BackColor = System.Drawing.Color.Transparent;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 374);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(357, 236);
            this.zedGraphControl1.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1008, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpen,
            this.itemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(117, 22);
            this.itemOpen.Text = "Open...";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(117, 22);
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemStart,
            this.itemPause,
            this.itemStop});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // itemStart
            // 
            this.itemStart.Name = "itemStart";
            this.itemStart.Size = new System.Drawing.Size(110, 22);
            this.itemStart.Text = "Start";
            this.itemStart.Click += new System.EventHandler(this.itemStart_Click);
            // 
            // itemPause
            // 
            this.itemPause.Name = "itemPause";
            this.itemPause.Size = new System.Drawing.Size(110, 22);
            this.itemPause.Text = "Pause";
            this.itemPause.Click += new System.EventHandler(this.itemPause_Click);
            // 
            // itemStop
            // 
            this.itemStop.Name = "itemStop";
            this.itemStop.Size = new System.Drawing.Size(110, 22);
            this.itemStop.Text = "Stop";
            this.itemStop.Click += new System.EventHandler(this.itemStop_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLegend,
            this.itemGraph,
            this.itemStatus,
            this.itemFullScreen});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // itemLegend
            // 
            this.itemLegend.Checked = true;
            this.itemLegend.CheckOnClick = true;
            this.itemLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemLegend.Name = "itemLegend";
            this.itemLegend.Size = new System.Drawing.Size(193, 22);
            this.itemLegend.Text = "Show Legend";
            this.itemLegend.Click += new System.EventHandler(this.itemLegend_Click);
            // 
            // itemGraph
            // 
            this.itemGraph.Checked = true;
            this.itemGraph.CheckOnClick = true;
            this.itemGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemGraph.Name = "itemGraph";
            this.itemGraph.Size = new System.Drawing.Size(193, 22);
            this.itemGraph.Text = "Show Graph";
            this.itemGraph.Click += new System.EventHandler(this.itemGraph_Click);
            // 
            // itemStatus
            // 
            this.itemStatus.Checked = true;
            this.itemStatus.CheckOnClick = true;
            this.itemStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemStatus.Name = "itemStatus";
            this.itemStatus.Size = new System.Drawing.Size(193, 22);
            this.itemStatus.Text = "Show Status";
            this.itemStatus.Click += new System.EventHandler(this.itemStatus_Click);
            // 
            // itemFullScreen
            // 
            this.itemFullScreen.CheckOnClick = true;
            this.itemFullScreen.Name = "itemFullScreen";
            this.itemFullScreen.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.itemFullScreen.Size = new System.Drawing.Size(193, 22);
            this.itemFullScreen.Text = "Enter Full Screen";
            this.itemFullScreen.Click += new System.EventHandler(this.itemFullScreen_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // itemAbout
            // 
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(111, 22);
            this.itemAbout.Text = "About";
            // 
            // grpLegend
            // 
            this.grpLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLegend.BackColor = System.Drawing.Color.Transparent;
            this.grpLegend.Controls.Add(this.textBox11);
            this.grpLegend.Controls.Add(this.btn10);
            this.grpLegend.Controls.Add(this.label12);
            this.grpLegend.Controls.Add(this.textBox10);
            this.grpLegend.Controls.Add(this.btnDefault);
            this.grpLegend.Controls.Add(this.textBox9);
            this.grpLegend.Controls.Add(this.textBox6);
            this.grpLegend.Controls.Add(this.btn9);
            this.grpLegend.Controls.Add(this.textBox8);
            this.grpLegend.Controls.Add(this.label3);
            this.grpLegend.Controls.Add(this.textBox7);
            this.grpLegend.Controls.Add(this.textBox5);
            this.grpLegend.Controls.Add(this.textBox4);
            this.grpLegend.Controls.Add(this.textBox3);
            this.grpLegend.Controls.Add(this.textBox2);
            this.grpLegend.Controls.Add(this.textBox1);
            this.grpLegend.Controls.Add(this.label10);
            this.grpLegend.Controls.Add(this.label11);
            this.grpLegend.Controls.Add(this.btn8);
            this.grpLegend.Controls.Add(this.btn7);
            this.grpLegend.Controls.Add(this.label9);
            this.grpLegend.Controls.Add(this.label8);
            this.grpLegend.Controls.Add(this.label7);
            this.grpLegend.Controls.Add(this.label6);
            this.grpLegend.Controls.Add(this.label5);
            this.grpLegend.Controls.Add(this.label4);
            this.grpLegend.Controls.Add(this.btn6);
            this.grpLegend.Controls.Add(this.btn5);
            this.grpLegend.Controls.Add(this.btn4);
            this.grpLegend.Controls.Add(this.btn3);
            this.grpLegend.Controls.Add(this.btn2);
            this.grpLegend.Controls.Add(this.btn1);
            this.grpLegend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpLegend.Location = new System.Drawing.Point(800, 374);
            this.grpLegend.Name = "grpLegend";
            this.grpLegend.Size = new System.Drawing.Size(208, 355);
            this.grpLegend.TabIndex = 7;
            this.grpLegend.TabStop = false;
            this.grpLegend.Text = "Legend";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox11.Location = new System.Drawing.Point(73, 289);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(127, 26);
            this.textBox11.TabIndex = 32;
            this.textBox11.Text = "Barren land";
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Plum;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Location = new System.Drawing.Point(12, 290);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(23, 23);
            this.btn10.TabIndex = 30;
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(36, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "10 -";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(73, 319);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(127, 26);
            this.textBox10.TabIndex = 29;
            this.textBox10.Text = "Other";
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.White;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.Location = new System.Drawing.Point(12, 320);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(23, 23);
            this.btnDefault.TabIndex = 27;
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btn_Click);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(73, 84);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(127, 26);
            this.textBox9.TabIndex = 26;
            this.textBox9.Text = "Forest";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(73, 259);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(127, 26);
            this.textBox6.TabIndex = 23;
            this.textBox6.Text = "Water";
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(12, 260);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(23, 23);
            this.btn9.TabIndex = 6;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(73, 142);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(127, 26);
            this.textBox8.TabIndex = 25;
            this.textBox8.Text = "Urban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(45, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "9 -";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(73, 113);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(127, 26);
            this.textBox7.TabIndex = 24;
            this.textBox7.Text = "Grass land";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(73, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 26);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "Arable land";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(73, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 26);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "Orchard";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(73, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 26);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Mining leases";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(73, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 26);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Rural settlements";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(73, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Road";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(45, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "8 -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(45, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "7 -";
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Maroon;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(12, 231);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(23, 23);
            this.btn8.TabIndex = 15;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(12, 202);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(23, 23);
            this.btn7.TabIndex = 14;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(45, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "6 -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(45, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "5 -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(45, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "4 -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(45, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "3 -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(45, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "2 -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(45, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "1 -";
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LightCoral;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(12, 173);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(23, 23);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Red;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(12, 144);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(23, 23);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Lime;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(12, 115);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(23, 23);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.ForestGreen;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(12, 86);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(23, 23);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Orange;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(12, 57);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(23, 23);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gold;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(12, 28);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(23, 23);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtGeneration
            // 
            this.txtGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneration.BackColor = System.Drawing.Color.White;
            this.txtGeneration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGeneration.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGeneration.ForeColor = System.Drawing.Color.Red;
            this.txtGeneration.Location = new System.Drawing.Point(100, 19);
            this.txtGeneration.Name = "txtGeneration";
            this.txtGeneration.ReadOnly = true;
            this.txtGeneration.Size = new System.Drawing.Size(102, 29);
            this.txtGeneration.TabIndex = 3;
            this.txtGeneration.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generation";
            // 
            // txtFitness
            // 
            this.txtFitness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFitness.BackColor = System.Drawing.Color.White;
            this.txtFitness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFitness.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFitness.ForeColor = System.Drawing.Color.Red;
            this.txtFitness.Location = new System.Drawing.Point(100, 54);
            this.txtFitness.Name = "txtFitness";
            this.txtFitness.ReadOnly = true;
            this.txtFitness.Size = new System.Drawing.Size(102, 29);
            this.txtFitness.TabIndex = 6;
            this.txtFitness.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fitness";
            // 
            // graph
            // 
            this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.graph.BackColor = System.Drawing.Color.Transparent;
            this.graph.Location = new System.Drawing.Point(0, 493);
            this.graph.Name = "graph";
            this.graph.ScrollGrace = 0D;
            this.graph.ScrollMaxX = 0D;
            this.graph.ScrollMaxY = 0D;
            this.graph.ScrollMaxY2 = 0D;
            this.graph.ScrollMinX = 0D;
            this.graph.ScrollMinY = 0D;
            this.graph.ScrollMinY2 = 0D;
            this.graph.Size = new System.Drawing.Size(357, 236);
            this.graph.TabIndex = 9;
            // 
            // picMap
            // 
            this.picMap.BackColor = System.Drawing.Color.White;
            this.picMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMap.Location = new System.Drawing.Point(0, 25);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(1008, 704);
            this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMap.TabIndex = 8;
            this.picMap.TabStop = false;
            // 
            // grpStatus
            // 
            this.grpStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStatus.BackColor = System.Drawing.Color.Transparent;
            this.grpStatus.Controls.Add(this.label2);
            this.grpStatus.Controls.Add(this.txtGeneration);
            this.grpStatus.Controls.Add(this.label1);
            this.grpStatus.Controls.Add(this.txtFitness);
            this.grpStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpStatus.Location = new System.Drawing.Point(800, 25);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(208, 90);
            this.grpStatus.TabIndex = 17;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.grpLegend);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.picMap);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Player";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.grpLegend.ResumeLayout(false);
            this.grpLegend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpLegend;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtGeneration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFitness;
        private System.Windows.Forms.Label label2;
        private ZedGraph.ZedGraphControl graph;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemStart;
        private System.Windows.Forms.ToolStripMenuItem itemLegend;
        private System.Windows.Forms.ToolStripMenuItem itemGraph;
        private System.Windows.Forms.ToolStripMenuItem itemStatus;
        private System.Windows.Forms.ToolStripMenuItem itemFullScreen;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem itemAbout;
        private System.Windows.Forms.ToolStripMenuItem itemStop;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem itemPause;
        private System.Windows.Forms.GroupBox grpStatus;

    }
}