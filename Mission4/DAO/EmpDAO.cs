using Mission4.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Mission4.DAO
{
    public class EmpDAO : IDAO<Emp>
    {
        //TODO
        //Terapkan pola Singleton untuk membatasi pembuatan objek yang tidak perlu.
        //Tambahkan konstrukotr private, private static EmpDAO empDAO Variabel dan

        //Tambahkan metode public static EmpDAO GetInstance().
        private static EmpDAO empDAO;
        private EmpDAO() { }
        public static EmpDAO GetInstance()
        {
            if (empDAO == null)
            {
                empDAO = new EmpDAO();
            }
            return empDAO;
        }
        public Emp Get(string empNo)
        { 
            Emp emp = null;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT e.Id, EmpNo, Name, Password, Title, HireDate, Salary, Bonus, d.Id DeptId, d.DeptName, d.LocId ");
            sql.Append("FROM Emp e LEFT OUTER JOIN Dept d ON e.DeptId = d.Id ");
            sql.Append("WHERE EmpNo = @EmpNo");

            //TODO
            //Terima informasi tentang karyawan tertentu yang nomor karyawannya adalah empNo, yang diterima sebagai parameter dari tabel Emp di DB. 
            //Simpan dan kembali ke objek Emp yang baru dibuat.  

            try
            {
                using (var db = new DBHelper())
                {
                    var con = db.Connection;
                    con.Open();

                    var cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@EmpNo", empNo);
                    //cmd.Parameters.Add("@EmpNo", SqlDbType.NVarChar).Value = empNo;
                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        emp = new Emp
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            EmpNo = reader["EmpNo"].ToString(),
                            Name = reader["Name"].ToString(),
                            Password = reader["Password"].ToString(),
                            Title = reader["Title"].ToString(),
                            HireDate = Convert.ToDateTime(reader["HireDate"]),
                            Salary = Convert.ToInt32(reader["Salary"]),
                            Bonus = Convert.ToInt32(reader["Bonus"]),
                            Dept = new Dept
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DeptName = reader["DeptName"].ToString(),
                                LocId = Convert.ToInt32(reader["LocId"])
                            }
                        };
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return emp;
        }

        public Emp Get(int id)
        {
            Emp emp = null;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT e.Id, e.EmpNo, e.Name, e.Password, e.Title, e.HireDate, e.Salary, e.Bonus, d.Id, d.DeptName, d.LocId ");
            sql.Append("FROM Emp e LEFT OUTER JOIN Dept d ON e.DeptId = d.Id ");
            sql.Append("WHERE e.Id = @Id");

            //TODO
            //Terima informasi karyawan tertentu dengan ID yang diterima sebagai parameter dari tabel Emp di DB sebagai kuncinya. 
            //Simpan dan kembali ke objek Emp yang baru dibuat.   
            try
            {
                using (var db = new DBHelper())
                {
                    var con = db.Connection;
                    con.Open();

                    var cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        emp = new Emp
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            EmpNo = reader["EmpNo"].ToString(),
                            Name = reader["Name"].ToString(),
                            Password = reader["Password"].ToString(),
                            Title = reader["Title"].ToString(),

                            HireDate = Convert.ToDateTime(reader["HireDate"]),

                            Salary = Convert.ToInt32(reader["Salary"]),
                            Bonus = Convert.ToInt32(reader["Bonus"]),
                            Dept = new Dept
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DeptName = reader["DeptName"].ToString(),
                                LocId = Convert.ToInt32(reader["LocId"])
                            }
                        };
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return emp;
        }

        public List<Emp> GetAll()
        {
            List<Emp> empList = new List<Emp>();

            //TODO
            //Menerima semua informasi departemen dari tabel EmpDAO di DB dan menyimpan informasi setiap departemen dalam objek Emp yang baru dibuat.
            //List<Emp> Mengembalikan semua item dalam daftar emp.
            //Peringatan: Properti Dept di objek Emp berisi objek Dept yang berisi informasi departemen di mana setiap karyawan berada.
            //      harus dimiliki.
            string sql = "SELECT e.Id, e.EmpNo, e.Name, e.Title, d.DeptName, FORMAT(e.HireDate, 'yyyy-MM-dd' ) AS HireDate FROM Emp e LEFT OUTER JOIN Dept d ON e.DeptId = d.Id";

            //TODO Selesaikan metode yang mengambil informasi tabel Departemen dari DB dan mengembalikannya dalam Collection.

            try
            {
                using (var db = new DBHelper())
                {
                    var con = db.Connection;
                    con.Open();

                    var cmd = new SqlCommand(sql, con);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var emp = new Emp
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            EmpNo = reader["EmpNo"].ToString(),
                            Name = reader["Name"].ToString(),

                            Title = reader["Title"].ToString(),
                            Dept = new Dept
                            {

                                DeptName = reader["DeptName"].ToString(),

                            },
                            HireDate = Convert.ToDateTime(reader["HireDate"])
                        };
                        empList.Add(emp);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Error");
            }
            return empList;
        }

        public int Add(Emp emp)
        {
            int affectedRow = 0;

            //TODO
            //Tambahkan konten objek Emp yang diterima sebagai parameter ke tabel Emp di DB dan mengembalikan jumlah baris yang diterapkan setelah operasi.
            //Peringatan: Nilai kolom Id dalam tabel Emp tidak boleh ditentukan karena nilai tersebut ditetapkan secara otomatis selama operasi tambahan.
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Emp (EmpNo, Name, Password, Title, DeptId, HireDate, ManagerId, Salary, Bonus)");
            sql.Append("VALUES (@EmpNo, @Name, @Password, @Title, @DeptId, @HireDate, @ManagerId, @Salary, @Bonus)");

            try
            {
                using (var db = new DBHelper())
                {
                    var con = db.Connection;
                    con.Open();

                    var cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Password", emp.Password);
                    cmd.Parameters.AddWithValue("@Title", emp.Title);
                    cmd.Parameters.AddWithValue("@DeptId", emp.DeptId);
                    cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                    cmd.Parameters.AddWithValue("@ManagerId", emp.ManagerId.HasValue ? (object)emp.ManagerId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                    cmd.Parameters.AddWithValue("@Bonus", emp.Bonus.HasValue ? (object)emp.Bonus.Value : DBNull.Value);

                    affectedRow = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Error");
            }
            return affectedRow;
        }

        public int Update(Emp emp)
        {
            int affectedRow = 0;

            //TODO
            //Perbarui konten objek Emp yang diterima sebagai parameter ke tabel Emp di DB dan mengembalikan jumlah baris yang diterapkan setelah operasi.  
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Emp ");
            sql.Append("SET EmpNo = @EmpNo, Name = @Name, Password = @Password, Title = @Title, ");
            sql.Append("DeptId = @DeptId, HireDate = @HireDate, ManagerId = @ManagerId, Salary = @Salary, Bonus = @Bonus ");
            sql.Append("WHERE Id = @Id");

            try
            {
                using (var db = new DBHelper())
                {
                    var con = db.Connection;
                    con.Open();

                    var cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Password", emp.Password);
                    cmd.Parameters.AddWithValue("@Title", emp.Title);
                    cmd.Parameters.AddWithValue("@DeptId", emp.DeptId); // Ensure DeptId is included
                    cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                    cmd.Parameters.AddWithValue("@ManagerId", emp.ManagerId.HasValue ? (object)emp.ManagerId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                    cmd.Parameters.AddWithValue("@Bonus", emp.Bonus.HasValue ? (object)emp.Bonus.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id", emp.Id);

                    affectedRow = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Error");
            }
            return affectedRow;
        }

        public int Delete(int id)
        {
            int affectedRow = 0;

            var sql1 = new StringBuilder();
            sql1.Append("DELETE FROM Certificate ");
            sql1.Append("WHERE EmpId = @EmpId");

            var sql2 = new StringBuilder();
            sql2.Append("DELETE FROM Emp ");
            sql2.Append("WHERE Id = @Id");

            try
            {
                using (var db = new DBHelper())
                {
                    db.Connection.Open();
                    var tx = db.Connection.BeginTransaction();

                    try
                    {
                        var cmd1 = new SqlCommand(sql1.ToString(), db.Connection, tx);
                        cmd1.Parameters.Add("@EmpId", SqlDbType.NVarChar).Value = id;
                        cmd1.ExecuteNonQuery();

                        //TODO
                        //Hapus karyawan yang ID-nya PK dari DB.
                        var cmd2 = new SqlCommand(sql2.ToString(), db.Connection, tx);
                        cmd2.Parameters.AddWithValue("@Id", id);
                        affectedRow = cmd2.ExecuteNonQuery();

                        tx.Commit();
                    }
                    catch (SqlException)
                    {
                        tx.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message, "Eror");
            }
            return affectedRow;
        }
    }
}
