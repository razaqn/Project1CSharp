using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project1
{
    internal class Auth
    {
        public string EmpID;
        public string EmpPassword;
        public int EmpPosition;
        public int HasilLogin = 0;
        public int HasilLogout = 0;

        Koneksi koneksi = new Koneksi();

        public void doLogin()
        {
            string nama;
            string email;
            int role;
            koneksi.bukaKoneksi();
            try
            {
                string query = "SELECT * FROM users.employee WHERE EmpID = @kode AND EmpPassword = @password";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@kode", EmpID);
                com.Parameters.AddWithValue("@password", EmpPassword);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string data = "SELECT EmpName, EmpEmail, EmpPosition from users.employee WHERE EmpID = @kode";
                    SqlCommand comdata = new SqlCommand(data, koneksi.con);
                    comdata.Parameters.AddWithValue("@kode", EmpID);
                    SqlDataReader sr = comdata.ExecuteReader();
                    if (sr.Read())
                    {
                        nama = sr[0].ToString();
                        email = sr[1].ToString();
                        role = Convert.ToInt32(sr[2].ToString());
                        GlobalVariable.name = nama;
                        GlobalVariable.email = email;
                        GlobalVariable.role = role;
                        GlobalVariable.kode = EmpID;
                        HasilLogin = 1;
                        HasilLogout = 0;
                        //Dashboard dashboard = new Dashboard();
                        //dashboard.Show();
                        //Application.OpenForms["FormLogin"].Hide();
                    }
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("login gagal");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            koneksi.tutupKoneksi();
        }

        public void doLogout()
        {
            GlobalVariable.name = "";
            GlobalVariable.email = "";
            GlobalVariable.role = 0;
            GlobalVariable.kode = "";
            HasilLogin = 0;
            HasilLogout = 1;
        }
    }
}
