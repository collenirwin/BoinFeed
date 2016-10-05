namespace BoinFeed {
    partial class NewsItem {
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
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.desc = new System.Windows.Forms.LinkLabel();
            this.linkButton = new boinon.boinon();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Controls.Add(this.desc, 0, 2);
            this.table.Controls.Add(this.linkButton, 0, 0);
            this.table.Controls.Add(this.imageBox, 0, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.Size = new System.Drawing.Size(230, 43);
            this.table.TabIndex = 4;
            // 
            // desc
            // 
            this.desc.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.desc.AutoEllipsis = true;
            this.desc.AutoSize = true;
            this.desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desc.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.desc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.desc.LinkColor = System.Drawing.Color.DodgerBlue;
            this.desc.Location = new System.Drawing.Point(3, 29);
            this.desc.MaximumSize = new System.Drawing.Size(224, 0);
            this.desc.MinimumSize = new System.Drawing.Size(224, 0);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(224, 14);
            this.desc.TabIndex = 4;
            this.desc.Text = "desc";
            this.desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.desc.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.desc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.desc_LinkClicked);
            // 
            // linkButton
            // 
            this.linkButton.activeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.linkButton.automaticColorChange = false;
            this.linkButton.AutoSize = true;
            this.linkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.linkButton.borderColor = System.Drawing.Color.Gainsboro;
            this.linkButton.borderStyleSpecial = false;
            this.linkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.linkButton.Location = new System.Drawing.Point(3, 0);
            this.linkButton.MaximumSize = new System.Drawing.Size(224, 0);
            this.linkButton.MinimumSize = new System.Drawing.Size(224, 0);
            this.linkButton.mouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.linkButton.mouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.linkButton.Name = "linkButton";
            this.linkButton.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.linkButton.Size = new System.Drawing.Size(224, 23);
            this.linkButton.TabIndex = 2;
            this.linkButton.Text = "Link";
            this.linkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(3, 26);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(224, 1);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 5;
            this.imageBox.TabStop = false;
            // 
            // NewsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Name = "NewsItem";
            this.Size = new System.Drawing.Size(230, 43);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private boinon.boinon linkButton;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.LinkLabel desc;


    }
}
