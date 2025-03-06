using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            txbkid.Text = "";
            txjudul.Text = "";
            txauthor.Text = "";
            txpublisher.Text = "";
            txyear.Text = "";
            txkategori.Text = "";
            txstock.Text = "";
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
            if (GlobalVariable.role != 99)
            {
                label4.Hide();
                btemployee.Hide();
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            Book Bk = new Book();
            Bk.BookID = txbkid.Text;
            Bk.Title = txjudul.Text;
            Bk.Author = txauthor.Text;
            Bk.Publisher = txpublisher.Text;
            Bk.YearPublished = Convert.ToInt32(txyear.Text);
            Bk.Category = txkategori.Text;
            Bk.Stock = Convert.ToInt32(txstock.Text);
            Bk.Update();
            loadData();
            ClearData();
        }

        private void btimport_Click(object sender, EventArgs e)
        {
            Book Bk = new Book();
            Bk.BookID = txbkid.Text;
            Bk.Title = txjudul.Text;
            Bk.Author = txauthor.Text;
            Bk.Publisher = txpublisher.Text;
            Bk.YearPublished = Convert.ToInt32(txyear.Text);
            Bk.Category = txkategori.Text;
            Bk.Stock = Convert.ToInt32(txstock.Text);
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
    }
}
