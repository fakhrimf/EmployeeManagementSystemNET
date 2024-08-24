using Mission4.DAO;
using Mission4.Entity;
using Mission4.View;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mission4.View
{
    public partial class frmEmpDetail : Form
    {
        public enum WorkTypeEnum { Add, Edit, Delete, View }
        public WorkTypeEnum WorkType { get; set; }
        public int EmpId { get; set; }

        public frmEmpDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            Emp emp;
            EmpDAO empDAO = EmpDAO.GetInstance();

            if (!ValidateAll())
                return;

            switch (WorkType)
            {
                case WorkTypeEnum.Add:
                    emp = new Emp
                    {
                        EmpNo = txtEmpNo.Text,
                        Name = txtName.Text,
                        Password = txtEmpNo.Text,
                        Title = txtTitle.Text,
                        HireDate = Convert.ToDateTime(txtHireDate.Text),
                        Salary = Convert.ToInt32(txtSalary.Text),
                        DeptId = cboDept.SelectedIndex > 0 ? Convert.ToInt32(cboDept.SelectedValue) : (int?)null,
                        ManagerId = cboManager.SelectedIndex > 0 ? Convert.ToInt32(cboManager.SelectedValue) : (int?)null,
                        Bonus = string.IsNullOrEmpty(txtBonus.Text) ? (int?)null : Convert.ToInt32(txtBonus.Text)
                    };

                    empDAO.Add(emp);

                    break;
                case WorkTypeEnum.Edit:
                    emp = empDAO.Get(EmpId);

                    emp.EmpNo = txtEmpNo.Text;
                    emp.Name = txtName.Text;
                    emp.Password = txtEmpNo.Text;
                    emp.Title = txtTitle.Text;
                    emp.HireDate = Convert.ToDateTime(txtHireDate.Text);
                    emp.Salary = Convert.ToInt32(txtSalary.Text);
                    emp.DeptId = cboDept.SelectedIndex > 0 ? Convert.ToInt32(cboDept.SelectedValue) : (int?)null;
                    emp.ManagerId = cboManager.SelectedIndex > 0 ? Convert.ToInt32(cboManager.SelectedValue) : (int?)null;
                    emp.Bonus = string.IsNullOrEmpty(txtBonus.Text) ? (int?)null : Convert.ToInt32(txtBonus.Text);

                    empDAO.Update(emp);

                    break;
                case WorkTypeEnum.Delete:
                    empDAO.Delete(EmpId);

                    break;
                case WorkTypeEnum.View:
                    break;
            }

            DialogResult = DialogResult.OK;
        }

        private void txtEmpNo_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmpNo();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            ValidateTitle();
        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            ValidateSalary();
        }
        private void txtHireDate_Validating(object sender, CancelEventArgs e)
        {
            ValidateHireDate();
        }

        protected bool ValidateHireDate()
        {
            DateTime hireDate;

            if (string.IsNullOrEmpty(txtHireDate.Text))
            {
                errHireDate.SetError(txtHireDate, "Silakan masukkan tanggal bergabung");
                return false;
            }
            else if (!DateTime.TryParse(txtHireDate.Text, out hireDate))
            {
                errHireDate.SetError(txtHireDate, "Silakan masukkan tanggal yang benar");
                return false;
            }
            else
            {
                errHireDate.Clear();
                return true;
            }
        }

        protected bool ValidateEmpNo()
        {
            if (string.IsNullOrEmpty(txtEmpNo.Text))
            {
                errEmpNo.SetError(txtEmpNo, "Silakan masukkan nomor karyawan");
                return false;
            }

            errEmpNo.Clear();

            return true;
        }

        protected bool ValidateName()
        {
            if (string.IsNullOrEmpty(txtEmpNo.Text))
            {
                errName.SetError(txtName, "Silahkan masukan nama");
                return false;
            }

            errName.Clear();

            return true;
        }

        protected bool ValidateTitle()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errTitle.SetError(txtTitle, "Silakan masukkan Jabatan");
                return false;
            }

            errTitle.Clear();

            return true;
        }

        protected bool ValidateSalary()
        {
            int sal;

            if (string.IsNullOrEmpty(txtSalary.Text))
            {
                errSalary.SetError(txtSalary, "Masukkan gaji Anda");
                return false;
            }
            else if (!int.TryParse(txtSalary.Text, out sal))
            {
                errSalary.SetError(txtSalary, "Silakan masukkan angka");
            }

            return true;
        }

        protected bool ValidateAll()
        {
            bool isValidated = true;

            if (!ValidateEmpNo())
                isValidated = false;
            else if (!ValidateName())
                isValidated = false;
            else if (!ValidateTitle())
                isValidated = false;
            else if (!ValidateSalary())
                isValidated = false;
            else if (!ValidateHireDate())
                isValidated = false;

            return isValidated;
        }

        private void frmEmpDetail_Load(object sender, EventArgs e)
        {
            lblEditCertificate.Visible = false;

            FillEmpFields();

            switch(WorkType)
            {
                case WorkTypeEnum.Add:
                    this.Text = "Tambahkan karyawan";
                    btnWork.Text = "Tambahkan";
                    break;
                case WorkTypeEnum.Edit:
                    this.Text = "Edit Karyawan";
                    btnWork.Text = "Edit";
                    lblEditCertificate.Visible = true;
                    break;
                case WorkTypeEnum.Delete:
                    this.Text = "Hapus Karyawan";
                    btnWork.Text = "Hapus";
                    DisableInput();
                    break;
                case WorkTypeEnum.View:
                    this.Text = "Detail Karyawan";
                    btnWork.Visible = false;
                    btnWork.Left = (this.Width - btnWork.Width) / 2;
                    DisableInput();
                    break;
            }
        }

        private void FillEmpFields()
        {
            RefreshDeptList();
            RefreshMangerList();

            var emp = EmpDAO.GetInstance().Get(EmpId);

            if (emp != null)
            {
                txtEmpNo.Text = emp.EmpNo;
                txtName.Text = emp.Name;
                txtTitle.Text = emp.Title;
                txtHireDate.Text = emp.HireDate.ToString("yyyy-MM-dd");
                txtSalary.Text = emp.Salary.ToString();
                txtBonus.Text = emp.Bonus.HasValue ? emp.Bonus.Value.ToString() : "";

                if (emp.DeptId.HasValue)
                    cboDept.SelectedValue = emp.DeptId;
                else
                    cboDept.SelectedIndex = 0;

                if (emp.ManagerId.HasValue)
                    cboManager.SelectedValue = emp.ManagerId;
                else
                    cboManager.SelectedIndex = 0;


                RefreshCertificateList();
            }
        }

        private void RefreshCertificateList()
        {
            lstCertificate.DisplayMember = "CertificateName";
            lstCertificate.ValueMember = "Id";
            lstCertificate.DataSource = CertificateDAO.GetInstance().GetAll(EmpId);
        }

        private void DisableInput()
        {
            txtEmpNo.ReadOnly = true;
            txtName.ReadOnly = true;
            txtTitle.ReadOnly = true;
            txtHireDate.ReadOnly = true;
            txtSalary.ReadOnly = true;
            txtBonus.ReadOnly = true;
            cboDept.Enabled = false;
            cboManager.Enabled = false;
        }

        private void RefreshDeptList()
        {
            var deptList = DeptDAO.GetInstance().GetAll();
            deptList.Insert(0, new Dept { Id = 0, DeptName = "(Tidak ada)" });
            cboDept.DisplayMember = "DeptName";
            cboDept.ValueMember = "Id";
            cboDept.DataSource = deptList;
        }

        private void RefreshMangerList()
        {
            var empList = EmpDAO.GetInstance().GetAll();
            empList.Insert(0, new Emp { Id = 0, Name = "(Tidak ada)" });
            cboManager.DisplayMember = "Name";
            cboManager.ValueMember = "Id";
            cboManager.DataSource = empList;
        }

        private void lblEditCertificate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmEmpCertificate();
            form.EmpId = EmpId;

            if (form.ShowDialog() == DialogResult.OK)
            {
                FillEmpFields();
            }
        }
    }
}
