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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            txphone.KeyPress += new KeyPressEventHandler(txphone_KeyPress);
        }

        private void txphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txname.Text))
            {
                MessageBox.Show("Name cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txpw.Text))
            {
                MessageBox.Show("Password cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(txemail.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

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
            if (!ValidateInput()) return;

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

        private void dgemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgemployee.RowCount - 1)
            {
                txid.Text = dgemployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                txname.Text = dgemployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                txpw.Text = dgemployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                txemail.Text = dgemployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                txphone.Text = dgemployee.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
