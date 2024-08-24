using Mission4.DAO;
using System;
using System.Windows.Forms;

namespace Mission4.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //TODO
            //EmpDAO Menggunakan objek, jika nomor pegawai dan password yang dimasukkan valid,(DB jika ada di tabel)
            //Panggil metode Hide() agar jendela login tidak terlihat.
            //Buat objek frmMain dan buka layar utama dengan metode ShowDialog().
            //Jika nomor karyawan atau kata sandi salah, kotak pesan akan ditampilkan seperti gambar di bawah ini 
            //Implement untuk terus melakukan operasi login.
            //(Provided already implemented!!!)

            if (!ValidateAll())
                return;

            var empDAO = EmpDAO.GetInstance();
            var emp = empDAO.Get(txtEmpNo.Text);

            if (emp == null || emp.Password != txtPassword.Text)
            {
                MessageBox.Show("ID atau kata sandi Anda salah.", "Login gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Hide();

            //Jika login berhasil, pindah ke layar utama
            Form form = new frmMain();
            form.ShowDialog();

            this.Close();
        }

        private bool ValidateEmpNo()
        {
            if (!string.IsNullOrEmpty(txtEmpNo.Text))
            {
                errEmpNo.Clear();
                return true;
            }
            else
            {
                errEmpNo.SetError(txtEmpNo, "Silakan masukkan nomor karyawan");
                return false;
            }
        }

        private bool ValidatePassword()
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                errPassword.Clear();
                return true;
            }
            else
            {
                errPassword.SetError(txtPassword, "Silahkan masukkan password");
                return false;
            }
        }

        private bool ValidateAll()
        {
            bool validated = true;

            if (!ValidateEmpNo())
                validated = false;
            else if (!ValidatePassword())
                validated = false;

            return validated;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmpNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateEmpNo();
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatePassword();
        }
    }
}
