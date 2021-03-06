﻿namespace zPoolMiner
{
    /// <summary>
    /// Defines the <see cref="Form_Main" />
    /// </summary>
    public partial class Form_Main
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.buttonStartMining = new System.Windows.Forms.Button();
            this.textBoxBTCAddress = new System.Windows.Forms.TextBox();
            this.labelServiceLocation = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.labelBitcoinAddress = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGlobalRateText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGlobalRateValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBTCDayText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBTCDayValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBalanceText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBalanceBTCValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBalanceBTCCode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBalanceDollarText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBalanceDollarValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelWorkerName = new System.Windows.Forms.Label();
            this.textBoxWorkerName = new System.Windows.Forms.TextBox();
            this.buttonStopMining = new System.Windows.Forms.Button();
            this.buttonBenchmark = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.linkLabelChooseBTCWallet = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelDemoMode = new System.Windows.Forms.Label();
            this.flowLayoutPanelRates = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_NotProfitable = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.linkLabelNewVersion = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deviceStats1 = new zPoolMiner.Forms.Components.DeviceStats();
            this.devicesListViewEnableControl1 = new zPoolMiner.Forms.Components.DevicesListViewEnableControl();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanelRates.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartMining
            // 
            this.buttonStartMining.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStartMining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStartMining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartMining.Location = new System.Drawing.Point(0, 0);
            this.buttonStartMining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartMining.Name = "buttonStartMining";
            this.buttonStartMining.Size = new System.Drawing.Size(98, 63);
            this.buttonStartMining.TabIndex = 6;
            this.buttonStartMining.Text = "&Start";
            this.buttonStartMining.UseVisualStyleBackColor = true;
            this.buttonStartMining.Click += new System.EventHandler(this.ButtonStartMining_Click);
            // 
            // textBoxBTCAddress
            // 
            this.textBoxBTCAddress.Location = new System.Drawing.Point(108, 4);
            this.textBoxBTCAddress.Name = "textBoxBTCAddress";
            this.textBoxBTCAddress.Size = new System.Drawing.Size(589, 21);
            this.textBoxBTCAddress.TabIndex = 1;
            this.textBoxBTCAddress.Leave += new System.EventHandler(this.TextBoxCheckBoxMain_Leave);
            // 
            // labelServiceLocation
            // 
            this.labelServiceLocation.AutoSize = true;
            this.labelServiceLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelServiceLocation.Location = new System.Drawing.Point(479, 36);
            this.labelServiceLocation.Name = "labelServiceLocation";
            this.labelServiceLocation.Size = new System.Drawing.Size(91, 16);
            this.labelServiceLocation.TabIndex = 99;
            this.labelServiceLocation.Text = "Service location:";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocation.Enabled = false;
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Zpool",
            "Future Pool",
            "Future Pool",
            "The Blocks Factory - unused",
            "Future Pool",
            "Future Pool"});
            this.comboBoxLocation.Location = new System.Drawing.Point(576, 31);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLocation.TabIndex = 0;
            this.comboBoxLocation.Leave += new System.EventHandler(this.TextBoxCheckBoxMain_Leave);
            // 
            // labelBitcoinAddress
            // 
            this.labelBitcoinAddress.AutoSize = true;
            this.labelBitcoinAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBitcoinAddress.Location = new System.Drawing.Point(16, 7);
            this.labelBitcoinAddress.Name = "labelBitcoinAddress";
            this.labelBitcoinAddress.Size = new System.Drawing.Size(86, 16);
            this.labelBitcoinAddress.TabIndex = 99;
            this.labelBitcoinAddress.Text = "Payout address:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGlobalRateText,
            this.toolStripStatusLabelGlobalRateValue,
            this.toolStripStatusLabelBTCDayText,
            this.toolStripStatusLabelBTCDayValue,
            this.toolStripStatusLabelBalanceText,
            this.toolStripStatusLabelBalanceBTCValue,
            this.toolStripStatusLabelBalanceBTCCode,
            this.toolStripStatusLabelBalanceDollarText,
            this.toolStripStatusLabelBalanceDollarValue,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGlobalRateText
            // 
            this.toolStripStatusLabelGlobalRateText.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelGlobalRateText.Name = "toolStripStatusLabelGlobalRateText";
            this.toolStripStatusLabelGlobalRateText.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabelGlobalRateText.Text = "Global rate:";
            // 
            // toolStripStatusLabelGlobalRateValue
            // 
            this.toolStripStatusLabelGlobalRateValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelGlobalRateValue.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelGlobalRateValue.Name = "toolStripStatusLabelGlobalRateValue";
            this.toolStripStatusLabelGlobalRateValue.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabelGlobalRateValue.Text = "0.00000000";
            // 
            // toolStripStatusLabelBTCDayText
            // 
            this.toolStripStatusLabelBTCDayText.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelBTCDayText.Name = "toolStripStatusLabelBTCDayText";
            this.toolStripStatusLabelBTCDayText.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabelBTCDayText.Text = "BTC/Day";
            // 
            // toolStripStatusLabelBTCDayValue
            // 
            this.toolStripStatusLabelBTCDayValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelBTCDayValue.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelBTCDayValue.Name = "toolStripStatusLabelBTCDayValue";
            this.toolStripStatusLabelBTCDayValue.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabelBTCDayValue.Text = "0.00";
            // 
            // toolStripStatusLabelBalanceText
            // 
            this.toolStripStatusLabelBalanceText.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelBalanceText.Name = "toolStripStatusLabelBalanceText";
            this.toolStripStatusLabelBalanceText.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabelBalanceText.Text = "$/Day";
            // 
            // toolStripStatusLabelBalanceBTCValue
            // 
            this.toolStripStatusLabelBalanceBTCValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelBalanceBTCValue.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelBalanceBTCValue.Name = "toolStripStatusLabelBalanceBTCValue";
            this.toolStripStatusLabelBalanceBTCValue.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabelBalanceBTCValue.Text = "0.00000000";
            // 
            // toolStripStatusLabelBalanceBTCCode
            // 
            this.toolStripStatusLabelBalanceBTCCode.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelBalanceBTCCode.Name = "toolStripStatusLabelBalanceBTCCode";
            this.toolStripStatusLabelBalanceBTCCode.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabelBalanceBTCCode.Text = "BTC";
            // 
            // toolStripStatusLabelBalanceDollarText
            // 
            this.toolStripStatusLabelBalanceDollarText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelBalanceDollarText.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelBalanceDollarText.Name = "toolStripStatusLabelBalanceDollarText";
            this.toolStripStatusLabelBalanceDollarText.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabelBalanceDollarText.Text = "0.00";
            // 
            // toolStripStatusLabelBalanceDollarValue
            // 
            this.toolStripStatusLabelBalanceDollarValue.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelBalanceDollarValue.Name = "toolStripStatusLabelBalanceDollarValue";
            this.toolStripStatusLabelBalanceDollarValue.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelBalanceDollarValue.Text = "$ ";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Image = global::zPoolMiner.Properties.Resources.NHM_Cash_Register_Bitcoin_transparent;
            this.toolStripStatusLabel10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(35, 20);
            this.toolStripStatusLabel10.Visible = false;
            this.toolStripStatusLabel10.Click += new System.EventHandler(this.ToolStripStatusLabel10_Click);
            this.toolStripStatusLabel10.MouseLeave += new System.EventHandler(this.ToolStripStatusLabel10_MouseLeave);
            this.toolStripStatusLabel10.MouseHover += new System.EventHandler(this.ToolStripStatusLabel10_MouseHover);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // labelWorkerName
            // 
            this.labelWorkerName.AutoSize = true;
            this.labelWorkerName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelWorkerName.Location = new System.Drawing.Point(16, 36);
            this.labelWorkerName.Name = "labelWorkerName";
            this.labelWorkerName.Size = new System.Drawing.Size(78, 16);
            this.labelWorkerName.TabIndex = 99;
            this.labelWorkerName.Text = "Worker name:";
            // 
            // textBoxWorkerName
            // 
            this.textBoxWorkerName.Location = new System.Drawing.Point(108, 33);
            this.textBoxWorkerName.Name = "textBoxWorkerName";
            this.textBoxWorkerName.Size = new System.Drawing.Size(365, 21);
            this.textBoxWorkerName.TabIndex = 2;
            this.textBoxWorkerName.Leave += new System.EventHandler(this.TextBoxCheckBoxMain_Leave);
            // 
            // buttonStopMining
            // 
            this.buttonStopMining.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStopMining.Enabled = false;
            this.buttonStopMining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonStopMining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopMining.Location = new System.Drawing.Point(98, 0);
            this.buttonStopMining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStopMining.Name = "buttonStopMining";
            this.buttonStopMining.Size = new System.Drawing.Size(98, 63);
            this.buttonStopMining.TabIndex = 7;
            this.buttonStopMining.Text = "St&op";
            this.buttonStopMining.UseVisualStyleBackColor = true;
            this.buttonStopMining.Click += new System.EventHandler(this.ButtonStopMining_Click);
            // 
            // buttonBenchmark
            // 
            this.buttonBenchmark.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBenchmark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBenchmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBenchmark.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBenchmark.Location = new System.Drawing.Point(408, 0);
            this.buttonBenchmark.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.buttonBenchmark.Name = "buttonBenchmark";
            this.buttonBenchmark.Size = new System.Drawing.Size(98, 63);
            this.buttonBenchmark.TabIndex = 4;
            this.buttonBenchmark.Text = "&Benchmark";
            this.buttonBenchmark.UseVisualStyleBackColor = true;
            this.buttonBenchmark.Click += new System.EventHandler(this.ButtonBenchmark_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(604, 0);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(98, 63);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "S&ettings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonLogo
            // 
            this.buttonLogo.BackColor = System.Drawing.Color.White;
            this.buttonLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLogo.FlatAppearance.BorderSize = 0;
            this.buttonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo.Image = global::zPoolMiner.Properties.Resources.NHM_logo_xsmall_light;
            this.buttonLogo.Location = new System.Drawing.Point(0, 0);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(162, 67);
            this.buttonLogo.TabIndex = 11;
            this.buttonLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonLogo.UseMnemonic = false;
            this.buttonLogo.UseVisualStyleBackColor = false;
            this.buttonLogo.Click += new System.EventHandler(this.ButtonLogo_Click);
            // 
            // linkLabelChooseBTCWallet
            // 
            this.linkLabelChooseBTCWallet.AutoSize = true;
            this.linkLabelChooseBTCWallet.Location = new System.Drawing.Point(325, 439);
            this.linkLabelChooseBTCWallet.Name = "linkLabelChooseBTCWallet";
            this.linkLabelChooseBTCWallet.Size = new System.Drawing.Size(175, 16);
            this.linkLabelChooseBTCWallet.TabIndex = 10;
            this.linkLabelChooseBTCWallet.TabStop = true;
            this.linkLabelChooseBTCWallet.Text = "Help me choose my Bitcoin wallet";
            this.linkLabelChooseBTCWallet.Visible = false;
            this.linkLabelChooseBTCWallet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelChooseBTCWallet_LinkClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // labelDemoMode
            // 
            this.labelDemoMode.AutoSize = true;
            this.labelDemoMode.BackColor = System.Drawing.Color.Transparent;
            this.labelDemoMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDemoMode.ForeColor = System.Drawing.Color.Red;
            this.labelDemoMode.Location = new System.Drawing.Point(6, 39);
            this.labelDemoMode.Name = "labelDemoMode";
            this.labelDemoMode.Size = new System.Drawing.Size(498, 25);
            this.labelDemoMode.TabIndex = 100;
            this.labelDemoMode.Text = "NiceHash Miner Legacy is running in DEMO mode!";
            this.labelDemoMode.Visible = false;
            // 
            // flowLayoutPanelRates
            // 
            this.flowLayoutPanelRates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRates.AutoScroll = true;
            this.flowLayoutPanelRates.Controls.Add(this.panel2);
            this.flowLayoutPanelRates.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRates.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanelRates.Name = "flowLayoutPanelRates";
            this.flowLayoutPanelRates.Size = new System.Drawing.Size(564, 32);
            this.flowLayoutPanelRates.TabIndex = 107;
            this.flowLayoutPanelRates.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label_NotProfitable);
            this.groupBox1.Controls.Add(this.flowLayoutPanelRates);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(1, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 69);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group/Device Rates:";
            // 
            // label_NotProfitable
            // 
            this.label_NotProfitable.AutoSize = true;
            this.label_NotProfitable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NotProfitable.ForeColor = System.Drawing.Color.Red;
            this.label_NotProfitable.Location = new System.Drawing.Point(6, 0);
            this.label_NotProfitable.Name = "label_NotProfitable";
            this.label_NotProfitable.Size = new System.Drawing.Size(366, 24);
            this.label_NotProfitable.TabIndex = 110;
            this.label_NotProfitable.Text = "CURRENTLY MINING NOT PROFITABLE.";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.White;
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(506, 0);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(98, 63);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "&Online Stats";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // linkLabelNewVersion
            // 
            this.linkLabelNewVersion.AutoSize = true;
            this.linkLabelNewVersion.Location = new System.Drawing.Point(292, 254);
            this.linkLabelNewVersion.Name = "linkLabelNewVersion";
            this.linkLabelNewVersion.Size = new System.Drawing.Size(0, 16);
            this.linkLabelNewVersion.TabIndex = 110;
            this.linkLabelNewVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelNewVersion_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.buttonBenchmark);
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonStopMining);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonStartMining);
            this.panel1.Location = new System.Drawing.Point(1, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 67);
            this.panel1.TabIndex = 111;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.buttonLogo);
            this.panel6.Location = new System.Drawing.Point(198, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(162, 67);
            this.panel6.TabIndex = 114;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelBitcoinAddress);
            this.panel3.Controls.Add(this.textBoxBTCAddress);
            this.panel3.Controls.Add(this.labelWorkerName);
            this.panel3.Controls.Add(this.comboBoxLocation);
            this.panel3.Controls.Add(this.textBoxWorkerName);
            this.panel3.Controls.Add(this.labelServiceLocation);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 62);
            this.panel3.TabIndex = 112;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.deviceStats1);
            this.panel5.Controls.Add(this.devicesListViewEnableControl1);
            this.panel5.Location = new System.Drawing.Point(1, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(706, 252);
            this.panel5.TabIndex = 114;
            // 
            // deviceStats1
            // 
            this.deviceStats1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceStats1.BenchmarkCalculation = null;
            this.deviceStats1.FirstColumnText = "Device Stats";
            this.deviceStats1.IsInBenchmark = false;
            this.deviceStats1.IsMining = false;
            this.deviceStats1.Location = new System.Drawing.Point(327, 4);
            this.deviceStats1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deviceStats1.Name = "deviceStats1";
            this.deviceStats1.SaveToGeneralConfig = false;
            this.deviceStats1.Size = new System.Drawing.Size(374, 244);
            this.deviceStats1.TabIndex = 110;
            // 
            // devicesListViewEnableControl1
            // 
            this.devicesListViewEnableControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesListViewEnableControl1.AutoSize = true;
            this.devicesListViewEnableControl1.BenchmarkCalculation = null;
            this.devicesListViewEnableControl1.FirstColumnText = "Enabled";
            this.devicesListViewEnableControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.devicesListViewEnableControl1.IsInBenchmark = false;
            this.devicesListViewEnableControl1.IsMining = false;
            this.devicesListViewEnableControl1.Location = new System.Drawing.Point(4, 3);
            this.devicesListViewEnableControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.devicesListViewEnableControl1.Name = "devicesListViewEnableControl1";
            this.devicesListViewEnableControl1.SaveToGeneralConfig = false;
            this.devicesListViewEnableControl1.Size = new System.Drawing.Size(319, 245);
            this.devicesListViewEnableControl1.TabIndex = 109;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(707, 486);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabelNewVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDemoMode);
            this.Controls.Add(this.linkLabelChooseBTCWallet);
            this.Controls.Add(this.statusStrip1);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 483);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZpoolMiner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form_Main_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanelRates.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Defines the buttonStartMining
        /// </summary>
        private System.Windows.Forms.Button buttonStartMining;

        /// <summary>
        /// Defines the labelServiceLocation
        /// </summary>
        private System.Windows.Forms.Label labelServiceLocation;

        /// <summary>
        /// Defines the labelBitcoinAddress
        /// </summary>
        private System.Windows.Forms.Label labelBitcoinAddress;

        /// <summary>
        /// Defines the statusStrip1
        /// </summary>
        private System.Windows.Forms.StatusStrip statusStrip1;

        /// <summary>
        /// Defines the labelWorkerName
        /// </summary>
        private System.Windows.Forms.Label labelWorkerName;

        /// <summary>
        /// Defines the toolStripStatusLabelGlobalRateValue
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGlobalRateValue;

        /// <summary>
        /// Defines the toolStripStatusLabelBalanceText
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBalanceText;

        /// <summary>
        /// Defines the toolStripStatusLabelBalanceBTCValue
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBalanceBTCValue;

        /// <summary>
        /// Defines the toolStripStatusLabelBalanceBTCCode
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBalanceBTCCode;

        /// <summary>
        /// Defines the toolStripStatusLabelGlobalRateText
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGlobalRateText;

        /// <summary>
        /// Defines the buttonStopMining
        /// </summary>
        private System.Windows.Forms.Button buttonStopMining;

        /// <summary>
        /// Defines the buttonBenchmark
        /// </summary>
        private System.Windows.Forms.Button buttonBenchmark;

        /// <summary>
        /// Defines the toolStripStatusLabelBTCDayText
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBTCDayText;

        /// <summary>
        /// Defines the toolStripStatusLabelBTCDayValue
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBTCDayValue;

        /// <summary>
        /// Defines the toolStripStatusLabelBalanceDollarText
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBalanceDollarText;

        /// <summary>
        /// Defines the toolStripStatusLabelBalanceDollarValue
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBalanceDollarValue;

        /// <summary>
        /// Defines the buttonSettings
        /// </summary>
        private System.Windows.Forms.Button buttonSettings;

        /// <summary>
        /// Defines the buttonLogo
        /// </summary>
        private System.Windows.Forms.Button buttonLogo;

        /// <summary>
        /// Defines the toolStripStatusLabel10
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;

        /// <summary>
        /// Defines the notifyIcon1
        /// </summary>
        private System.Windows.Forms.NotifyIcon notifyIcon1;

        /// <summary>
        /// Defines the textBoxBTCAddress
        /// </summary>
        private System.Windows.Forms.TextBox textBoxBTCAddress;

        /// <summary>
        /// Defines the comboBoxLocation
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxLocation;

        /// <summary>
        /// Defines the textBoxWorkerName
        /// </summary>
        private System.Windows.Forms.TextBox textBoxWorkerName;

        /// <summary>
        /// Defines the linkLabelChooseBTCWallet
        /// </summary>
        private System.Windows.Forms.LinkLabel linkLabelChooseBTCWallet;

        /// <summary>
        /// Defines the labelDemoMode
        /// </summary>
        private System.Windows.Forms.Label labelDemoMode;

        /// <summary>
        /// Defines the flowLayoutPanelRates
        /// </summary>
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRates;

        /// <summary>
        /// Defines the groupBox1
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;

        /// <summary>
        /// Defines the label_NotProfitable
        /// </summary>
        private System.Windows.Forms.Label label_NotProfitable;

        /// <summary>
        /// Defines the devicesListViewEnableControl1
        /// </summary>
        private Forms.Components.DevicesListViewEnableControl devicesListViewEnableControl1;

        /// <summary>
        /// Defines the buttonHelp
        /// </summary>
        private System.Windows.Forms.Button buttonHelp;

        /// <summary>
        /// Defines the linkLabelNewVersion
        /// </summary>
        private System.Windows.Forms.LinkLabel linkLabelNewVersion;

        /// <summary>
        /// Defines the toolTip1
        /// </summary>
        private System.Windows.Forms.ToolTip toolTip1;

        /// <summary>
        /// Defines the toolStripStatusLabel1
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        /// <summary>
        /// Defines the panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;

        /// <summary>
        /// Defines the panel2
        /// </summary>
        private System.Windows.Forms.Panel panel2;

        /// <summary>
        /// Defines the panel3
        /// </summary>
        private System.Windows.Forms.Panel panel3;

        /// <summary>
        /// Defines the panel6
        /// </summary>
        private System.Windows.Forms.Panel panel6;
        private Forms.Components.DeviceStats deviceStats;
        private System.Windows.Forms.Panel panel5;
        private Forms.Components.DeviceStats deviceStats1;
    }
}
