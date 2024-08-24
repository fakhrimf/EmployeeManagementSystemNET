using Mission4.DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Mission4.View
{
    public partial class frmEmpMgt : Form
    {
        public frmEmpMgt()
        {
            InitializeComponent();
        }

        private void frmEmpMgt_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var emp = EmpDAO.GetInstance().GetAll();
            dgvEmp.AutoGenerateColumns = false;
            dgvEmp.DataSource = emp.Select(p => new { p.Id, p.EmpNo, p.Name, p.HireDate, p.Title, p.Dept?.DeptName }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmEmpDetail();
            form.WorkType = frmEmpDetail.WorkTypeEnum.Add;

            if (form.ShowDialog() != DialogResult.Cancel)
                RefreshGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int empId = GetSelectedEmpId();

            if (empId == 0)
            {
                MessageBox.Show("Pertama, pilih karyawan yang ingin diedit.", "Kesalahan Tugas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var form = new frmEmpDetail();
            form.WorkType = frmEmpDetail.WorkTypeEnum.Edit;
            form.EmpId = empId;

            if (form.ShowDialog() != DialogResult.Cancel)
                RefreshGrid();
        }

        private int GetSelectedEmpId()
        {
            if (dgvEmp.CurrentRow != null)
                return Convert.ToInt32(dgvEmp.CurrentRow.Cells[0].Value);
            else
                return 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int empId = GetSelectedEmpId();

            if (empId == 0)
            {
                MessageBox.Show("Pertama, pilih karyawan yang ingin dihapus.", "Kesalhan tugas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var form = new frmEmpDetail();
            form.WorkType = frmEmpDetail.WorkTypeEnum.Delete;
            form.EmpId = empId;

            if (form.ShowDialog() != DialogResult.Cancel)
                RefreshGrid();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int empId = GetSelectedEmpId();

            if (empId == 0)
            {
                MessageBox.Show("Pertama, pilih karyawan yang ingin dicari.", "Kesalahan tugas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var form = new frmEmpDetail();
            form.WorkType = frmEmpDetail.WorkTypeEnum.View;
            form.EmpId = empId;

            if (form.ShowDialog() != DialogResult.Cancel)
                RefreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
