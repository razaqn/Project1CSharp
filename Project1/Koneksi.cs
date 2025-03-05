using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    internal class Koneksi
    {
        string source;
        public SqlConnection con;

        public Koneksi()
        {
            try
            {
                source = "Integrated Security=true;Initial Catalog=dblibrary;Data Source=.";
                con = new SqlConnection(source);
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error : " + sqle.Message);
            }
        }

        public void bukaKoneksi()
        {
            try
            {
                con.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error : " + sqle.Message);
            }
        }

        public void tutupKoneksi()
        {
            try
            {
                con.Close();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error : " + sqle.Message);
            }
        }
    }
}
