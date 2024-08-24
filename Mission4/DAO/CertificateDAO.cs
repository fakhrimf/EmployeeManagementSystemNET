using Mission4.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace Mission4.DAO
{
    public class CertificateDAO : IDAO<Certificate>
    {
        //TODO
        //Terapkan pola Singleton untuk membatasi pembuatan objek yang tidak perlu.
        //Tambahkan konstruktor, private static CertificateDAO certificateDAO Variabel dan 
        //Tambahkan metode public static CertificateDAO GetInstance().
        private static CertificateDAO certificateDAO;
        private CertificateDAO() { }
        public static CertificateDAO GetInstance()
        {
            if (certificateDAO == null)
            {
                certificateDAO = new CertificateDAO();
            }
            return certificateDAO;
        }
        public List<Certificate> GetAll(int empId)
        {
            List<Certificate> certificateList = new List<Certificate>();

            //TODO
            //Terima semua informasi departemen dari tabel CertificateDAO DB dan buat informasi baru untuk setiap departemen. Pada objek Certificate 
            //Simpan dan kembalikan semua item dalam daftar sertifikat List<Certificate>..
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM Certificate WHERE EmpId = @EmpId");

            try
            {
                using (var db = new DBHelper())
                {
                    var con = db.Connection;
                    con.Open();

                    var cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@EmpId", empId);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var certificate = new Certificate
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            EmpId = Convert.ToInt32(reader["EmpId"]),
                            CertificateName = reader["CertificateName"].ToString(),
                        };
                        certificateList.Add(certificate);
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return certificateList;
        }

        public Certificate Get(int id)
        {
            Certificate certificate = null;

            //TODO
            //Terima informasi sertifikat tertentu dengan ID yang diterima sebagai parameter dari tabel Sertifikat DB sebagai kuncinya.
            //Simpan dan kembali ke objek Sertifikat yang baru dibuat..   
           
            string sql = "SELECT * FROM Certificate WHERE Id = @Id";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    certificate = new Certificate
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        EmpId = Convert.ToInt32(reader["EmpId"]),
                        CertificateName = reader["CertificateName"].ToString(),
                    };
                }
                reader.Close();
            }
            return certificate;
        }

        public int Add(Certificate certificate)
        {
            int affectedRows = 0;

            //TODO
            //Tambahkan konten objek Sertifikat yang diterima sebagai parameter ke tabel Sertifikat di DB,
            //Kembalikan jumlah baris yang diterapkan setelah operasi.
            //Peringatan: Nilai kolom Id dalam tabel Sertifikat tidak boleh ditentukan karena secara otomatis ditetapkan selama pekerjaan tambahan.
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Certificate (EmpId, CertificateName) ");
            sql.Append("VALUES (@EmpId, @CertificateName)");

            try
            {
                using (var db = new DBHelper())
                {
                    var con = db.Connection;
                    con.Open();

                    var cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@EmpId", certificate.EmpId);
                    cmd.Parameters.AddWithValue("@CertificateName", certificate.CertificateName);

                    affectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return affectedRows;
        }

        public int Update(Certificate certificate)
        {
            int affectedRows = 0;

            //TODO
            //Perbarui konten objek Sertifikat yang diterima sebagai parameter ke tabel Sertifikat di DB., 
            //Kembalikan jumlah baris yang diterapkan setelah operasi.
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Certificate ");
            sql.Append("SET EmpId = @EmpId, CertificateName = @CertificateName");
            sql.Append("WHERE Id = @Id");

            try
            {
                using (var db = new DBHelper())
                {
                    var con = db.Connection;
                    con.Open();

                    var cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@EmpId", certificate.EmpId);
                    cmd.Parameters.AddWithValue("@CertificateName", certificate.CertificateName);
                    cmd.Parameters.AddWithValue("@Id", certificate.Id);

                    affectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return affectedRows;
        }

        public int Delete(int id)
        {
            int affectedRows = 0;

            //TODO
            //Hapus informasi kredensial tertentu dari DB dengan nilai id yang diterima sebagai parameter sebagai kunci.,
            //Mengembalikan jumlah baris yang diterapkan setelah operasi.  
            string sql = "DELETE FROM Certificate WHERE Id = @Id";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql.ToString(), con);
                //cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                affectedRows = cmd.ExecuteNonQuery();
            }
            return affectedRows;
        }

        //metode yang tidak digunakan lagi
        public List<Certificate> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
