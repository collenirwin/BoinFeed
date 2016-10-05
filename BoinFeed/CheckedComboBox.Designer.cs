namespace BoinFeed {
    partial class CheckedComboBox {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnDrop = new boinon.boinon();
            this.lst = new System.Windows.Forms.CheckedListBox();
            this.btnClose = new boinon.boinon();
            this.btnSelectAll = new boinon.boinon();
            this.SuspendLayout();
            // 
            // btnDrop
            // 
            this.btnDrop.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDrop.automaticColorChange = false;
            this.btnDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDrop.borderColor = System.Drawing.Color.Gainsboro;
            this.btnDrop.borderStyleSpecial = false;
            this.btnDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDrop.Location = new System.Drawing.Point(0, 0);
            this.btnDrop.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDrop.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(75, 23);
            this.btnDrop.TabIndex = 2;
            this.btnDrop.Text = "Filter";
            this.btnDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // lst
            // 
            this.lst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst.CheckOnClick = true;
            this.lst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(0, 23);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(156, 135);
            this.lst.Sorted = true;
            this.lst.TabIndex = 3;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnClose.automaticColorChange = false;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.borderColor = System.Drawing.Color.Gainsboro;
            this.btnClose.borderStyleSpecial = false;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnClose.Location = new System.Drawing.Point(130, 0);
            this.btnClose.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClose.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSelectAll.automaticColorChange = false;
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSelectAll.borderColor = System.Drawing.Color.Gainsboro;
            this.btnSelectAll.borderStyleSpecial = false;
            this.btnSelectAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSelectAll.Location = new System.Drawing.Point(0, 158);
            this.btnSelectAll.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSelectAll.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(156, 23);
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // CheckedComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.btnDrop);
            this.Name = "CheckedComboBox";
            this.Size = new System.Drawing.Size(156, 185);
            this.ResumeLayout(false);

        }

        #endregion

        private boinon.boinon btnDrop;
        private boinon.boinon btnClose;
        public System.Windows.Forms.CheckedListBox lst;
        private boinon.boinon btnSelectAll;

    }
}
