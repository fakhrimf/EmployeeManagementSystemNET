using System;
using System.Windows.Forms;

namespace Mission4.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Apakah Anda ingin keluar dari program?", "Konfirmasi keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void mnuDeptMgt_Click(object sender, EventArgs e)
        {
            var form = new frmDeptMgt();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuEmpMgt_Click(object sender, EventArgs e)
        {
            var form = new frmEmpMgt();
            form.MdiParent = this;
            form.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDeptMgt_Click(object sender, EventArgs e)
        {
            mnuDeptMgt_Click(this, null);
        }

        private void btnEmpMgt_Click(object sender, EventArgs e)
        {
            mnuEmpMgt_Click(this, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
