using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        void loadData()
        {
            Book Bk = new Book();
            DataSet ds = new DataSet();
            ds = Bk.Read();
            dgbook.DataSource = ds;
            dgbook.DataMember = "buku";
        }

        void ClearData()
        {
            btdeletebk.Enabled = false;
            btupdate.Enabled = false;
            btimport.Enabled = true;
            txbkid.Text = "";
            txjudul.Text = "";
            txauthor.Text = "";
            txpublisher.Text = "";
            nuyearp.Value = 0;
            txkategori.Text = "";
            nustock.Value = 0;
        }

        private void btdashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsb = new Dashboard();
            dsb.Show();
            this.Hide();
        }

        private void btmember_Click(object sender, EventArgs e)
        {
            FormMember fmb = new FormMember();
            fmb.Show();
            this.Hide();
        }

        private void bttransaction_Click(object sender, EventArgs e)
        {
            FormTransaction fts = new FormTransaction();
            fts.Show();
            this.Hide();
        }

        private void btemployee_Click(object sender, EventArgs e)
        {
            FormEmployee fem = new FormEmployee();
            fem.Show();
            this.Hide();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.doLogout();
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            loadData();
            btdeletebk.Enabled = false;
            btupdate.Enabled = false;
            btimport.Enabled = true;
            if (GlobalVariable.role != 99)
            {
                label4.Hide();
                btemployee.Hide();
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txjudul.Text))
            {
                MessageBox.Show("Title is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txauthor.Text))
            {
                MessageBox.Show("Author is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txpublisher.Text))
            {
                MessageBox.Show("Publisher is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nuyearp.Value == 0)
            {
                MessageBox.Show("Year Published is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txkategori.Text))
            {
                MessageBox.Show("Category is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nustock.Value < 0)
            {
                MessageBox.Show("Stock must be 0 or greater", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Book Bk = new Book();
            Bk.BookID = txbkid.Text;
            Bk.Title = txjudul.Text;
            Bk.Author = txauthor.Text;
            Bk.Publisher = txpublisher.Text;
            Bk.YearPublished = Convert.ToInt32(nuyearp.Value);
            Bk.Category = txkategori.Text;
            Bk.Stock = Convert.ToInt32(nustock.Value);
            Bk.Update();
            loadData();
            ClearData();
        }

        private void btimport_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Book Bk = new Book();
            Bk.BookID = txbkid.Text;
            Bk.Title = txjudul.Text;
            Bk.Author = txauthor.Text;
            Bk.Publisher = txpublisher.Text;
            Bk.YearPublished = Convert.ToInt32(nuyearp.Value);
            Bk.Category = txkategori.Text;
            Bk.Stock = Convert.ToInt32(nustock.Value);
            Bk.Create();
            loadData();
            ClearData();
        }

        private void btdeletebk_Click(object sender, EventArgs e)
        {

            Book Bk = new Book();
            Bk.BookID = txbkid.Text;
            Bk.Delete();
            loadData();
            ClearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dgbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txbkid.Text = dgbook.Rows[e.RowIndex].Cells[0].Value.ToString();
                txjudul.Text = dgbook.Rows[e.RowIndex].Cells[1].Value.ToString();
                txauthor.Text = dgbook.Rows[e.RowIndex].Cells[2].Value.ToString();
                txpublisher.Text = dgbook.Rows[e.RowIndex].Cells[3].Value.ToString();
                nuyearp.Value = Convert.ToInt32(dgbook.Rows[e.RowIndex].Cells[4].Value.ToString());
                txkategori.Text = dgbook.Rows[e.RowIndex].Cells[5].Value.ToString();
                nustock.Value = Convert.ToInt32(dgbook.Rows[e.RowIndex].Cells[6].Value.ToString());
                btdeletebk.Enabled = true;
                btupdate.Enabled = true;
                btimport.Enabled = false;
            }
        }
    }
}
