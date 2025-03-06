using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    internal class Employee
    {
        public string EmpID;
        public string EmpName;
        public string EmpPassword;
        public int EmpPosition;
        public string EmpEmail;
        public string EmpPhone;

        Koneksi koneksi = new Koneksi();

        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO users.employee VALUES (@ID, @nama, @password, @posisi, @email, @nomer_telpon)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@ID", GlobalVariable.empid());
                com.Parameters.AddWithValue("@nama", EmpName);
                com.Parameters.AddWithValue("@password", EmpPassword);
                com.Parameters.AddWithValue("@posisi", "0");
                com.Parameters.AddWithValue("@email", EmpEmail);
                com.Parameters.AddWithValue("@nomer_telpon", EmpPhone);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil dimasukan");
                }
                else
                {
                    MessageBox.Show("Data gagal dimasukan");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
        public DataSet Read()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT * FROM users.employee";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Pegawai");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public void Update()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "UPDATE users.employee SET EmpName = @nama, EmpPassword = @password, EmpEmail = @email WHERE EmpID = @ID";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@ID", EmpID);
                com.Parameters.AddWithValue("@nama", EmpName);
                com.Parameters.AddWithValue("@password", EmpPassword);
                com.Parameters.AddWithValue("@email", EmpEmail);
                com.Parameters.AddWithValue("@nomer_telpon", EmpPhone);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil Diubah");
                }
                else
                {
                    MessageBox.Show("Data gagal Diubah");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }

        public void Delete()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "DELETE users.employee WHERE EmpID= @ID";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@ID", EmpID);

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil Dihapus");
                }
                else
                {
                    MessageBox.Show("Data gagal Dihapus");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
