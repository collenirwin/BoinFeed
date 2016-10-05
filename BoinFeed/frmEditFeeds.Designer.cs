namespace BoinFeed {
    partial class frmEditFeeds {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditFeeds));
            this.lstMain = new System.Windows.Forms.ListBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblRefRate = new System.Windows.Forms.Label();
            this.btnAddFeed = new boinon.boinon();
            this.btnRemove = new boinon.boinon();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoneEdit = new boinon.boinon();
            this.btnEditName = new boinon.boinon();
            this.SuspendLayout();
            // 
            // lstMain
            // 
            this.lstMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lstMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lstMain.FormattingEnabled = true;
            this.lstMain.Location = new System.Drawing.Point(0, 56);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(383, 169);
            this.lstMain.TabIndex = 1;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtURL.Location = new System.Drawing.Point(65, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(225, 19);
            this.txtURL.TabIndex = 0;
            // 
            // lblRefRate
            // 
            this.lblRefRate.AutoSize = true;
            this.lblRefRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblRefRate.Location = new System.Drawing.Point(8, 9);
            this.lblRefRate.Name = "lblRefRate";
            this.lblRefRate.Size = new System.Drawing.Size(57, 13);
            this.lblRefRate.TabIndex = 10;
            this.lblRefRate.Text = "RSS URL:";
            // 
            // btnAddFeed
            // 
            this.btnAddFeed.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAddFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFeed.automaticColorChange = false;
            this.btnAddFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddFeed.borderColor = System.Drawing.Color.Gainsboro;
            this.btnAddFeed.borderStyleSpecial = false;
            this.btnAddFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAddFeed.Location = new System.Drawing.Point(296, 4);
            this.btnAddFeed.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAddFeed.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.Size = new System.Drawing.Size(75, 23);
            this.btnAddFeed.TabIndex = 11;
            this.btnAddFeed.Text = "Add Feed";
            this.btnAddFeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFeed.Click += new System.EventHandler(this.btnAddFeed_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.automaticColorChange = false;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRemove.borderColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.borderStyleSpecial = false;
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnRemove.Location = new System.Drawing.Point(284, 235);
            this.btnRemove.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnRemove.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove Feed";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtName.Location = new System.Drawing.Point(65, 31);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 19);
            this.txtName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // btnDoneEdit
            // 
            this.btnDoneEdit.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoneEdit.automaticColorChange = false;
            this.btnDoneEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDoneEdit.borderColor = System.Drawing.Color.Gainsboro;
            this.btnDoneEdit.borderStyleSpecial = false;
            this.btnDoneEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDoneEdit.Location = new System.Drawing.Point(296, 30);
            this.btnDoneEdit.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDoneEdit.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDoneEdit.Name = "btnDoneEdit";
            this.btnDoneEdit.Size = new System.Drawing.Size(75, 23);
            this.btnDoneEdit.TabIndex = 15;
            this.btnDoneEdit.Text = "Done";
            this.btnDoneEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoneEdit.Visible = false;
            this.btnDoneEdit.Click += new System.EventHandler(this.btnDoneEdit_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEditName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditName.automaticColorChange = false;
            this.btnEditName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEditName.borderColor = System.Drawing.Color.Gainsboro;
            this.btnEditName.borderStyleSpecial = false;
            this.btnEditName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEditName.Location = new System.Drawing.Point(205, 235);
            this.btnEditName.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEditName.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(73, 23);
            this.btnEditName.TabIndex = 16;
            this.btnEditName.Text = "Edit Feed";
            this.btnEditName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // frmEditFeeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(383, 267);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.btnDoneEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddFeed);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblRefRate);
            this.Controls.Add(this.lstMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditFeeds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoinFeed - Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditFeeds_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMain;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblRefRate;
        private boinon.boinon btnAddFeed;
        private boinon.boinon btnRemove;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private boinon.boinon btnDoneEdit;
        private boinon.boinon btnEditName;
    }
}