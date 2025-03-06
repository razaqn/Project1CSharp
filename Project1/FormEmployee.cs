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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        void loadData()
        {
            Employee emp = new Employee();
            DataSet ds = new DataSet();
            ds = emp.Read();
            dgemployee.DataSource = ds;
            dgemployee.DataMember = "pegawai";
        }
        void ClearData()
        {
            txid.Text = "";
            txname.Text = "";
            txpw.Text = "";
            txemail.Text = "";
            txphone.Text = "";
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

        private void btbook_Click(object sender, EventArgs e)
        {
            FormBook fbk = new FormBook();
            fbk.Show();
            this.Hide();
        }

        private void bttransaction_Click(object sender, EventArgs e)
        {
            FormTransaction fts = new FormTransaction();
            fts.Show();
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

        private void btadd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpID = txid.Text;
            emp.EmpName = txname.Text;
            emp.EmpPassword = txpw.Text;
            emp.EmpEmail = txemail.Text;
            emp.EmpPhone = txphone.Text;
            emp.Create();
            loadData();
            ClearData();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpID = txid.Text;
            emp.EmpName = txname.Text;
            emp.EmpPassword = txpw.Text;
            emp.EmpEmail = txemail.Text;
            emp.EmpPhone = txphone.Text;
            emp.Update();
            loadData();
            ClearData();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpID = txid.Text;
            emp.Delete();
            loadData();
            ClearData();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
