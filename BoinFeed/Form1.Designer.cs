namespace BoinFeed {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pctLoad = new System.Windows.Forms.PictureBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.btnReconnect = new boinon.boinon();
            this.cboRefRate = new System.Windows.Forms.ComboBox();
            this.btnFocusGrab = new System.Windows.Forms.Button();
            this.lblRefRate = new System.Windows.Forms.Label();
            this.tmrRef = new System.Windows.Forms.Timer(this.components);
            this.bgwRSS = new System.ComponentModel.BackgroundWorker();
            this.tmrServerTimeout = new System.Windows.Forms.Timer(this.components);
            this.bgwPurge = new System.ComponentModel.BackgroundWorker();
            this.cboFilter = new BoinFeed.CheckedComboBox();
            this.btnOptions = new boinon.boinon();
            this.btnEditFeeds = new boinon.boinon();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlMain.Controls.Add(this.pctLoad);
            this.pnlMain.Controls.Add(this.lblCountdown);
            this.pnlMain.Controls.Add(this.btnReconnect);
            this.pnlMain.Location = new System.Drawing.Point(0, 29);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10, 4, 2, 4);
            this.pnlMain.Size = new System.Drawing.Size(512, 132);
            this.pnlMain.TabIndex = 6;
            this.pnlMain.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlMain_Scroll);
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_MouseEnter);
            this.pnlMain.MouseEnter += new System.EventHandler(this.pnlMain_MouseEnter);
            // 
            // pctLoad
            // 
            this.pctLoad.Image = ((System.Drawing.Image)(resources.GetObject("pctLoad.Image")));
            this.pctLoad.Location = new System.Drawing.Point(13, 7);
            this.pctLoad.Name = "pctLoad";
            this.pctLoad.Size = new System.Drawing.Size(256, 88);
            this.pctLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctLoad.TabIndex = 0;
            this.pctLoad.TabStop = false;
            this.pctLoad.Visible = false;
            // 
            // lblCountdown
            // 
            this.lblCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCountdown.Location = new System.Drawing.Point(275, 4);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 25);
            this.lblCountdown.TabIndex = 12;
            this.lblCountdown.Tag = "Fetching feeds in ";
            this.lblCountdown.Visible = false;
            // 
            // btnReconnect
            // 
            this.btnReconnect.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnReconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReconnect.automaticColorChange = false;
            this.btnReconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnReconnect.borderColor = System.Drawing.Color.Gainsboro;
            this.btnReconnect.borderStyleSpecial = false;
            this.btnReconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnReconnect.Location = new System.Drawing.Point(281, 4);
            this.btnReconnect.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReconnect.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(75, 23);
            this.btnReconnect.TabIndex = 10;
            this.btnReconnect.Text = "Refresh";
            this.btnReconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReconnect.Visible = false;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // cboRefRate
            // 
            this.cboRefRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRefRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cboRefRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRefRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRefRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cboRefRate.FormattingEnabled = true;
            this.cboRefRate.Items.AddRange(new object[] {
            "5 minutes",
            "10 minutes",
            "30 minutes"});
            this.cboRefRate.Location = new System.Drawing.Point(277, 4);
            this.cboRefRate.Name = "cboRefRate";
            this.cboRefRate.Size = new System.Drawing.Size(85, 21);
            this.cboRefRate.TabIndex = 7;
            this.cboRefRate.TabStop = false;
            this.cboRefRate.SelectedIndexChanged += new System.EventHandler(this.cboRefRate_SelectedIndexChanged);
            this.cboRefRate.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // btnFocusGrab
            // 
            this.btnFocusGrab.Location = new System.Drawing.Point(-26, 0);
            this.btnFocusGrab.Name = "btnFocusGrab";
            this.btnFocusGrab.Size = new System.Drawing.Size(10, 11);
            this.btnFocusGrab.TabIndex = 8;
            this.btnFocusGrab.Text = "button1";
            this.btnFocusGrab.UseVisualStyleBackColor = true;
            // 
            // lblRefRate
            // 
            this.lblRefRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRefRate.AutoSize = true;
            this.lblRefRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblRefRate.Location = new System.Drawing.Point(215, 7);
            this.lblRefRate.Name = "lblRefRate";
            this.lblRefRate.Size = new System.Drawing.Size(63, 13);
            this.lblRefRate.TabIndex = 9;
            this.lblRefRate.Text = "refresh rate:";
            // 
            // tmrRef
            // 
            this.tmrRef.Interval = 60000;
            this.tmrRef.Tick += new System.EventHandler(this.tmrRef_Tick);
            // 
            // bgwRSS
            // 
            this.bgwRSS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRSS_DoWork);
            this.bgwRSS.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRSS_RunWorkerCompleted);
            // 
            // tmrServerTimeout
            // 
            this.tmrServerTimeout.Interval = 1000;
            this.tmrServerTimeout.Tick += new System.EventHandler(this.tmrServerTimeout_Tick);
            // 
            // bgwPurge
            // 
            this.bgwPurge.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwPurge_DoWork);
            // 
            // cboFilter
            // 
            this.cboFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cboFilter.Location = new System.Drawing.Point(12, 3);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(75, 23);
            this.cboFilter.TabIndex = 10;
            this.cboFilter.Visible = false;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // btnOptions
            // 
            this.btnOptions.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.automaticColorChange = false;
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnOptions.borderColor = System.Drawing.Color.Gainsboro;
            this.btnOptions.borderStyleSpecial = false;
            this.btnOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnOptions.Location = new System.Drawing.Point(449, 2);
            this.btnOptions.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnOptions.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(51, 23);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnEditFeeds
            // 
            this.btnEditFeeds.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEditFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFeeds.automaticColorChange = false;
            this.btnEditFeeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEditFeeds.borderColor = System.Drawing.Color.Gainsboro;
            this.btnEditFeeds.borderStyleSpecial = false;
            this.btnEditFeeds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEditFeeds.Location = new System.Drawing.Point(368, 3);
            this.btnEditFeeds.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEditFeeds.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEditFeeds.Name = "btnEditFeeds";
            this.btnEditFeeds.Size = new System.Drawing.Size(75, 23);
            this.btnEditFeeds.TabIndex = 1;
            this.btnEditFeeds.Text = "Edit Feeds";
            this.btnEditFeeds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditFeeds.Click += new System.EventHandler(this.btnEditFeeds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(512, 161);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.cboRefRate);
            this.Controls.Add(this.lblRefRate);
            this.Controls.Add(this.btnFocusGrab);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnEditFeeds);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(314, 100);
            this.Name = "Form1";
            this.Text = "BoinFeed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private boinon.boinon btnEditFeeds;
        private boinon.boinon btnOptions;
        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.ComboBox cboRefRate;
        private System.Windows.Forms.Button btnFocusGrab;
        private System.Windows.Forms.Label lblRefRate;
        private System.Windows.Forms.Timer tmrRef;
        private System.ComponentModel.BackgroundWorker bgwRSS;
        private System.Windows.Forms.Timer tmrServerTimeout;
        private boinon.boinon btnReconnect;
        private System.ComponentModel.BackgroundWorker bgwPurge;
        private System.Windows.Forms.PictureBox pctLoad;
        private System.Windows.Forms.Label lblCountdown;
        private CheckedComboBox cboFilter;
    }
}

