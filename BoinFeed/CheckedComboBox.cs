using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoinFeed {
    public partial class CheckedComboBox : UserControl {

        public event EventHandler SelectedIndexChanged;

        bool isOpen = false;

        public CheckedComboBox() {
            InitializeComponent();
            toggle(false);
        }

        public void toggle(bool open) {
            this.Size = (open) ? new Size(156, 181) : btnDrop.Size;

            this.lst.Visible = open;
            this.btnClose.Visible = open;
            this.isOpen = open;
        }

        public void selectAll() {
            for (int x = 0; x < lst.Items.Count; x++)
                lst.SetItemChecked(x, true);
        }

        public bool isDropped() {
            return this.isOpen;
        }

        private void btnDrop_Click(object sender, EventArgs e) {
            toggle(!this.isOpen);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            toggle(false);
        }

        private void btnSelectAll_Click(object sender, EventArgs e) {
            selectAll();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e) {
            lst.SelectedIndex = -1;

            // Pass this event to the parent of this control
            if (this.SelectedIndexChanged != null)
                this.SelectedIndexChanged(this, e);
        }
    }
}
