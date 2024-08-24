using Mission4.DAO;
using System;
using System.Windows.Forms;

namespace Mission4.View
{
    public partial class frmDeptMgt : Form
    {
        public frmDeptMgt()
        {
            InitializeComponent();
        }

        private void frmDeptMgt_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvDept.AutoGenerateColumns = false;
            var deptList = DeptDAO.GetInstance().GetAll();
            dgvDept.DataSource = deptList;
        }

        private int GetSelectedDeptId()
        {
            if (dgvDept.CurrentRow != null)
                return Convert.ToInt32(dgvDept.CurrentRow.Cells[0].Value);
            else
                return 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmDeptDetail();
            form.WorkType = frmDeptDetail.WorkTypeEnum.Add;

            if (form.ShowDialog() != DialogResult.Cancel)
                RefreshGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int deptId = GetSelectedDeptId();

            if (deptId == 0)
            {
                MessageBox.Show("Pertama, pilih departemen yang ingin diedit.", "Kesalahan tugas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var form = new frmDeptDetail();
            form.WorkType = frmDeptDetail.WorkTypeEnum.Edit;
            form.DeptId = deptId;

            if (form.ShowDialog() != DialogResult.Cancel)
                RefreshGrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int deptId = GetSelectedDeptId();

            if (deptId == 0)
            {
                MessageBox.Show("Pertama, pilih departemen yang ingin dihapus.", "Kesalahan tugas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var form = new frmDeptDetail();
            form.WorkType = frmDeptDetail.WorkTypeEnum.Delete;
            form.DeptId = deptId;

            if (form.ShowDialog() != DialogResult.Cancel)
                RefreshGrid();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int deptId = GetSelectedDeptId();

            if (deptId == 0)
            {
                MessageBox.Show("Pertama, pilih departemen yang ingin Anda lihat detailnya.", "Kesalahan tugas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var form = new frmDeptDetail();
            form.WorkType = frmDeptDetail.WorkTypeEnum.View;
            form.DeptId = deptId;

            if (form.ShowDialog() != DialogResult.Cancel)
                RefreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
