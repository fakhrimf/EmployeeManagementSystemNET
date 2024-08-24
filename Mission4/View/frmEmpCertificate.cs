using Mission4.DAO;
using Mission4.Entity;
using System;
using System.Windows.Forms;

namespace Mission4.View
{
    public partial class frmEmpCertificate : Form
    {
        public int EmpId { get; set; }

        public frmEmpCertificate()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCertificate.SelectedIndex >= 0)
            {
                CertificateDAO.GetInstance().Delete(Convert.ToInt32(lstCertificate.SelectedValue));
                DialogResult = DialogResult.OK;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCertificate.Text))
            {
                var certificate = new Certificate
                {
                    EmpId = EmpId,
                    CertificateName = txtCertificate.Text
                };

                CertificateDAO.GetInstance().Add(certificate);
            }

            DialogResult = DialogResult.OK;
        }

        private void frmEmpCertificate_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            lstCertificate.DisplayMember = "CertificateName";
            lstCertificate.ValueMember = "Id";
            lstCertificate.DataSource = CertificateDAO.GetInstance().GetAll(EmpId);
        }
    }
}
