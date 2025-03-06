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
    internal class Book
    {
        public string BookID;
        public string Title;
        public string Author;
        public string Publisher;
        public int YearPublished;
        public string Category;
        public int Stock;

        Koneksi koneksi = new Koneksi();

        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO items.book VALUES (@ID, @judul, @author, @publisher, @tahun, @kategori, @stok)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@ID", BookID);
                com.Parameters.AddWithValue("@judul", Title);
                com.Parameters.AddWithValue("@author", Author);
                com.Parameters.AddWithValue("@publisher", Publisher);
                com.Parameters.AddWithValue("@tahun", YearPublished);
                com.Parameters.AddWithValue("@kategori", Category);
                com.Parameters.AddWithValue("@stok", Stock);
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
                string query = "SELECT * FROM items.book";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Buku");
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
                string query = "UPDATE items.book SET Title = @judul, Author = @author, Publisher = @publisher, YearPublished = @tahun, Category = @kategori, Stock = @stok WHERE BookID = @ID";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@ID", BookID);
                com.Parameters.AddWithValue("@judul", Title);
                com.Parameters.AddWithValue("@author", Author);
                com.Parameters.AddWithValue("@publisher", Publisher);
                com.Parameters.AddWithValue("@tahun", YearPublished);
                com.Parameters.AddWithValue("@kategori", Category);
                com.Parameters.AddWithValue("@stok", Stock);
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
                string query = "DELETE items.book WHERE BookID= @ID";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@ID", BookID);

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
