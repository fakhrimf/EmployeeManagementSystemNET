using Mission4.DAO;
using Mission4.Entity;
using System;
using System.Windows.Forms;

namespace Mission4.View
{
    public partial class frmDeptDetail : Form
    {
        public int DeptId { get; set; }
        public enum WorkTypeEnum { Add, Edit, Delete, View }
        public WorkTypeEnum WorkType { get; set; }

        public frmDeptDetail()
        {
            InitializeComponent();
        }

        private void txtDeptName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateDeptName();
        }

        protected bool ValidateDeptName()
        {
            if (string.IsNullOrEmpty(txtDeptName.Text))
            {
                errDeptName.SetError(txtDeptName, "Silakan masukkan ID departemen Anda");
                return false;
            }
            else
            {
                errDeptName.SetError(txtDeptName, "");
                return true;
            }
        }

        private void txtLocId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateLocId();
        }

        protected bool ValidateLocId()
        {
            if (string.IsNullOrEmpty(txtLocId.Text))
            {
                errLocId.SetError(txtLocId, "Silakan masukkan ID area Anda");
                return false;
            }
            else
            {
                errLocId.SetError(txtLocId, "");
                return true;
            }
        }

        protected bool ValidateAll()
        {
            bool isValidated = true;

            if (!ValidateDeptName())
                isValidated = false;

            if (!ValidateLocId())
                isValidated = false;

            return isValidated;
        }

        private void frmDeptDetail_Load(object sender, EventArgs e)
        {
            
            InitControls();

            switch (WorkType)
            {
                case WorkTypeEnum.Add:
                    this.Text = "Tambahkan departemen";
                    btnWork.Text = "Tambahkan";
                    break;
                case WorkTypeEnum.Edit:
                    this.Text = "Edit departemen";
                    btnWork.Text = "Edit";
                    break;
                case WorkTypeEnum.Delete:
                    this.Text = "Hapus departemen";
                    btnWork.Text = "Hapus";
                    txtDeptName.ReadOnly = true;
                    txtLocId.ReadOnly = true;
                    break;
                case WorkTypeEnum.View:
                    this.Text = "Lihat departemen";
                    btnWork.Visible = false;
                    btnClose.Left = (this.Width - btnClose.Width) / 2;
                    txtDeptName.ReadOnly = true;
                    txtLocId.ReadOnly = true;
                    break;
            }
        }

        private void InitControls()
        {
            if (DeptId > 0)
            {
                var dept = DeptDAO.GetInstance().Get(DeptId);
                lblDeptId.Text = dept.Id.ToString();
                txtDeptName.Text = dept.DeptName;
                txtLocId.Text = dept.LocId.ToString();
            }

        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            Dept dept;
            DeptDAO deptDAO = DeptDAO.GetInstance();

            if (!ValidateAll())
                return;

            switch (WorkType)
            {
                case WorkTypeEnum.Add:
                    dept = new Dept
                    {
                        DeptName = txtDeptName.Text,
                        LocId = Convert.ToInt32(txtLocId.Text)
                    };

                    deptDAO.Add(dept);

                    break;
                case WorkTypeEnum.Edit:
                    dept = DeptDAO.GetInstance().Get(DeptId);

                    if (dept != null)
                    {
                        dept.DeptName = txtDeptName.Text;
                        dept.LocId = Convert.ToInt32(txtLocId.Text);

                        DeptDAO.GetInstance().Update(dept);

                        DialogResult = DialogResult.OK;
                    }

                    break;
                case WorkTypeEnum.Delete:
                    int deletedRow = DeptDAO.GetInstance().Delete(DeptId);

                    if (deletedRow == 0)
                        MessageBox.Show("Departemen tidak bisa di hapus.", "Penghapusan eror", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    break;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
