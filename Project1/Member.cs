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
    internal class Member
    {
        public string MemberID;
        public string MemberName;
        public string MemberEmail;
        public string MemberPhone;
        public DateTime JoinDate;

        Koneksi koneksi = new Koneksi();

        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO items.member VALUES (@MID, @nama, @email, @nomer_telepon, @tanggal_gabung)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@MID", MemberID);
                com.Parameters.AddWithValue("@nama", MemberName);
                com.Parameters.AddWithValue("@email", MemberEmail);
                com.Parameters.AddWithValue("@nomer_telepon", MemberPhone);
                com.Parameters.AddWithValue("@tanggal_gabung", JoinDate);
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
                string query = "SELECT * FROM items.member";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Member");
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
                string query = "UPDATE items.member SET MemberName = @nama, MemberEmail = @email, MemberPhone = @nomer_telepon, JoinDate = @tanggal_gabung WHERE MemberID = @MID";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@MID", MemberID);
                com.Parameters.AddWithValue("@nama", MemberName);
                com.Parameters.AddWithValue("@email", MemberEmail);
                com.Parameters.AddWithValue("@nomer_telepon", MemberPhone);
                com.Parameters.AddWithValue("@tanggal_gabung", JoinDate);
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
                string query = "DELETE items.member WHERE MemberID= @MID";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@MID", MemberID);

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
