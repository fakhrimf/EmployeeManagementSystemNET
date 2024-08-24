using Mission4.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Mission4.DAO
{
    public class DeptDAO : IDAO<Dept>
    {
        //TODO
        //Terapkan pola Singleton untuk membatasi pembuatan objek yang tidak perlu.
        //Tambahkan konstruktor private, private static DeptDAO deptDAO; Variabel dan
        //Tambahkan metode public static DeptDAO GetInstance().
     
        private static DeptDAO deptDAO;
        private DeptDAO() { }
        public static DeptDAO GetInstance() {
            if (deptDAO == null)
            {
                deptDAO = new DeptDAO();
            }
            return deptDAO;
        }
        public List<Dept> GetAll()
        {
            //TODO
            //Menerima semua informasi departemen dari tabel Dept di DB dan menyimpan informasi setiap departemen dalam objek Dept yang baru dibuat 
            //Kembalikan semua yang ada dalam daftar departemen List<Dept>.
            //(Provided already implemented!!!)

            List<Dept> depts = new List<Dept>();
            string sql = "SELECT * FROM dept";

            //TODO Selesaikan metode yang mengambil informasi tabel Departemen dari DB dan mengembalikannya dalam Collection.
            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var dept = new Dept
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DeptName = reader["DeptName"].ToString(),
                        LocId = Convert.ToInt32(reader["LocId"])
                    };

                    depts.Add(dept);
                }

                reader.Close();
            }

            return depts;
        }

        public Dept Get(int id)
        {
            Dept dept = null;

            //TODO
            //Terima informasi departemen tertentu dengan ID yang diterima sebagai parameter dari tabel Dept DB sebagai kuncinya. 
            //yang sudah dibuat Simpan dan kembalikan Dept.   

            string sql = "SELECT * FROM dept WHERE Id = @Id";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dept = new Dept
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DeptName = reader["DeptName"].ToString(),
                        LocId = Convert.ToInt32(reader["LocId"])
                    };
                }

                reader.Close();
            }

            return dept;
        }

        public int Add(Dept dept)
        {
            int affectedRows = 0;

            //TODO
            //Tambahkan konten objek Dept yang diterima sebagai parameter ke tabel Dept di DB dan mengembalikan jumlah baris yang diterapkan setelah operasi.  
            //Peringatan: Nilai kolom Id pada tabel Dept tidak boleh ditentukan karena secara otomatis ditetapkan selama pekerjaan tambahan.
            string sql = "INSERT INTO dept (DeptName, LocId) VALUES (@DeptName, @LocId)";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@DeptName", dept.DeptName);
                cmd.Parameters.AddWithValue("@LocId", dept.LocId);

                affectedRows = cmd.ExecuteNonQuery();
            }

            return affectedRows;
        }

        public int Update(Dept dept)
        {
            int affectedRows = 0;

            //TODO
            //Perbarui konten objek Dept yang diterima sebagai parameter ke tabel Dept di DB dan mengembalikan jumlah baris yang diterapkan setelah operasi.
            string sql = "UPDATE dept SET DeptName = @DeptName, LocId = @LocId WHERE Id = @Id";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@DeptName", dept.DeptName);
                cmd.Parameters.AddWithValue("@LocId", dept.LocId);
                cmd.Parameters.AddWithValue("@Id", dept.Id);

                affectedRows = cmd.ExecuteNonQuery();
            }
            return affectedRows;
        }

        public int Delete(int id)
        {
            int affectedRows = 0;

            //TODO
            //Hapus informasi departemen tertentu dari DB dengan nilai id yang diterima sebagai parameter sebagai kunci dan mengembalikan jumlah baris yang diterapkan setelah operasi.  
            string sql = "DELETE FROM dept WHERE Id = @Id";
            using (var db = new DBHelper())
            {
                try
                {
                    var con = db.Connection;
                    con.Open();

                    var cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    affectedRows = cmd.ExecuteNonQuery();
                }
                catch (SqlException ex) {
                    Debug.WriteLine(ex);
                }
                
            }
            return affectedRows;
        }
    }
}
