namespace BoinFeed {
    partial class frmOptions {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.btnEditColor = new boinon.boinon();
            this.btnResetColor = new boinon.boinon();
            this.radTitle = new System.Windows.Forms.RadioButton();
            this.radTitleDesc = new System.Windows.Forms.RadioButton();
            this.radTitleDescImage = new System.Windows.Forms.RadioButton();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblVerAuth = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnClose = new boinon.boinon();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cdTheme = new System.Windows.Forms.ColorDialog();
            this.btnResetAllSettings = new boinon.boinon();
            this.SuspendLayout();
            // 
            // btnEditColor
            // 
            this.btnEditColor.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEditColor.automaticColorChange = false;
            this.btnEditColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEditColor.borderColor = System.Drawing.Color.Gainsboro;
            this.btnEditColor.borderStyleSpecial = false;
            this.btnEditColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEditColor.Location = new System.Drawing.Point(26, 139);
            this.btnEditColor.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEditColor.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEditColor.Name = "btnEditColor";
            this.btnEditColor.Size = new System.Drawing.Size(48, 23);
            this.btnEditColor.TabIndex = 3;
            this.btnEditColor.Text = "Edit";
            this.btnEditColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditColor.Click += new System.EventHandler(this.btnEditColor_Click);
            // 
            // btnResetColor
            // 
            this.btnResetColor.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnResetColor.automaticColorChange = false;
            this.btnResetColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnResetColor.borderColor = System.Drawing.Color.Gainsboro;
            this.btnResetColor.borderStyleSpecial = false;
            this.btnResetColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnResetColor.Location = new System.Drawing.Point(85, 139);
            this.btnResetColor.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnResetColor.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnResetColor.Name = "btnResetColor";
            this.btnResetColor.Size = new System.Drawing.Size(48, 23);
            this.btnResetColor.TabIndex = 4;
            this.btnResetColor.Text = "Reset";
            this.btnResetColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResetColor.Click += new System.EventHandler(this.btnResetColor_Click);
            // 
            // radTitle
            // 
            this.radTitle.AutoSize = true;
            this.radTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.radTitle.Location = new System.Drawing.Point(29, 37);
            this.radTitle.Name = "radTitle";
            this.radTitle.Size = new System.Drawing.Size(45, 17);
            this.radTitle.TabIndex = 5;
            this.radTitle.TabStop = true;
            this.radTitle.Text = "Title";
            this.radTitle.UseVisualStyleBackColor = true;
            this.radTitle.CheckedChanged += new System.EventHandler(this.radTitle_CheckedChanged);
            // 
            // radTitleDesc
            // 
            this.radTitleDesc.AutoSize = true;
            this.radTitleDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.radTitleDesc.Location = new System.Drawing.Point(29, 60);
            this.radTitleDesc.Name = "radTitleDesc";
            this.radTitleDesc.Size = new System.Drawing.Size(104, 17);
            this.radTitleDesc.TabIndex = 6;
            this.radTitleDesc.TabStop = true;
            this.radTitleDesc.Text = "Title+Description";
            this.radTitleDesc.UseVisualStyleBackColor = true;
            this.radTitleDesc.CheckedChanged += new System.EventHandler(this.radTitleDesc_CheckedChanged);
            // 
            // radTitleDescImage
            // 
            this.radTitleDescImage.AutoSize = true;
            this.radTitleDescImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.radTitleDescImage.Location = new System.Drawing.Point(29, 83);
            this.radTitleDescImage.Name = "radTitleDescImage";
            this.radTitleDescImage.Size = new System.Drawing.Size(139, 17);
            this.radTitleDescImage.TabIndex = 7;
            this.radTitleDescImage.TabStop = true;
            this.radTitleDescImage.Text = "Title+Description+Image";
            this.radTitleDescImage.UseVisualStyleBackColor = true;
            this.radTitleDescImage.CheckedChanged += new System.EventHandler(this.radTitleDescImage_CheckedChanged);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblStyle.Location = new System.Drawing.Point(12, 9);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(165, 25);
            this.lblStyle.TabIndex = 8;
            this.lblStyle.Text = "News Item Style";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblColor.Location = new System.Drawing.Point(10, 114);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(118, 25);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Feed Color";
            // 
            // lblVerAuth
            // 
            this.lblVerAuth.AutoSize = true;
            this.lblVerAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblVerAuth.Location = new System.Drawing.Point(10, 171);
            this.lblVerAuth.Name = "lblVerAuth";
            this.lblVerAuth.Size = new System.Drawing.Size(154, 25);
            this.lblVerAuth.TabIndex = 10;
            this.lblVerAuth.Text = "Version/Author";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblVersion.Location = new System.Drawing.Point(26, 196);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(29, 15);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "v1.0";
            // 
            // btnClose
            // 
            this.btnClose.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.automaticColorChange = false;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.borderColor = System.Drawing.Color.Gainsboro;
            this.btnClose.borderStyleSpecial = false;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnClose.Location = new System.Drawing.Point(156, 248);
            this.btnClose.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClose.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblName.Location = new System.Drawing.Point(26, 211);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 15);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Collen Irwin";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblEmail.Location = new System.Drawing.Point(26, 226);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(136, 15);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "collenirwin@gmail.com";
            // 
            // cdTheme
            // 
            this.cdTheme.FullOpen = true;
            this.cdTheme.SolidColorOnly = true;
            // 
            // btnResetAllSettings
            // 
            this.btnResetAllSettings.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnResetAllSettings.automaticColorChange = false;
            this.btnResetAllSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnResetAllSettings.borderColor = System.Drawing.Color.Gainsboro;
            this.btnResetAllSettings.borderStyleSpecial = false;
            this.btnResetAllSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnResetAllSettings.Location = new System.Drawing.Point(47, 248);
            this.btnResetAllSettings.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnResetAllSettings.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnResetAllSettings.Name = "btnResetAllSettings";
            this.btnResetAllSettings.Size = new System.Drawing.Size(103, 23);
            this.btnResetAllSettings.TabIndex = 15;
            this.btnResetAllSettings.Text = "Reset All Settings";
            this.btnResetAllSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResetAllSettings.Click += new System.EventHandler(this.btnResetAllSettings_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(216, 280);
            this.Controls.Add(this.btnResetAllSettings);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblVerAuth);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.radTitleDescImage);
            this.Controls.Add(this.radTitleDesc);
            this.Controls.Add(this.radTitle);
            this.Controls.Add(this.btnResetColor);
            this.Controls.Add(this.btnEditColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoinFeed - Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOptions_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private boinon.boinon btnEditColor;
        private boinon.boinon btnResetColor;
        private System.Windows.Forms.RadioButton radTitle;
        private System.Windows.Forms.RadioButton radTitleDesc;
        private System.Windows.Forms.RadioButton radTitleDescImage;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblVerAuth;
        private System.Windows.Forms.Label lblVersion;
        private boinon.boinon btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ColorDialog cdTheme;
        private boinon.boinon btnResetAllSettings;
    }
}