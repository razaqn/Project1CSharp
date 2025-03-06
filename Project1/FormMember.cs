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
using System.Net.Mail;

namespace Project1
{
    public partial class FormMember : Form
    {
        public FormMember()
        {
            InitializeComponent();
            txphone_member.KeyPress += new KeyPressEventHandler(txphone_member_KeyPress);
        }

        void loadData()
        {
            Member mbr = new Member();
            DataSet ds = new DataSet();
            ds = mbr.Read();
            dgmember.DataSource = ds;
            dgmember.DataMember = "member";
        }

        void ClearData()
        {
            txid_member.Text = "";
            txnama_member.Text = "";
            txemail_member.Text = "";
            txphone_member.Text = "";
            dtmember.Text = "";
            btupdate_m.Enabled = false;
            btdelete_m.Enabled = false;
            btimport_m.Enabled = true;
        }

        private void btdashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsb = new Dashboard();
            dsb.Show();
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

        private void FormMember_Load(object sender, EventArgs e)
        {
            loadData();
            btupdate_m.Enabled = false;
            btdelete_m.Enabled = false;
            btimport_m.Enabled = true;
            if (GlobalVariable.role != 99)
            {
                label4.Hide();
                btemployee.Hide();
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txnama_member.Text))
            {
                MessageBox.Show("Member name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txemail_member.Text))
            {
                MessageBox.Show("Member email cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!IsValidEmail(txemail_member.Text))
            {
                MessageBox.Show("Please enter a valid email address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btimport_m_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            Member mbr = new Member();
            mbr.MemberID = txid_member.Text;
            mbr.MemberName = txnama_member.Text;
            mbr.MemberEmail = txemail_member.Text;
            mbr.MemberPhone = txphone_member.Text;
            mbr.JoinDate = Convert.ToDateTime(dtmember.Value);
            mbr.Create();
            loadData();
            ClearData();
        }

        private void btupdate_m_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            Member mbr = new Member();
            mbr.MemberID = txid_member.Text;
            mbr.MemberName = txnama_member.Text;
            mbr.MemberEmail = txemail_member.Text;
            mbr.MemberPhone = txphone_member.Text;
            mbr.JoinDate = Convert.ToDateTime(dtmember.Value);
            mbr.Update();
            loadData();
            ClearData();
        }

        private void btdelete_m_Click(object sender, EventArgs e)
        {
            Member mbr = new Member();
            mbr.MemberID = txid_member.Text;
            mbr.Delete();
            loadData();
            ClearData();
        }

        private void txphone_member_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dgmember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgmember.RowCount - 1)
            {
                txid_member.Text = dgmember.Rows[e.RowIndex].Cells[0].Value.ToString();
                txnama_member.Text = dgmember.Rows[e.RowIndex].Cells[1].Value.ToString();
                txemail_member.Text = dgmember.Rows[e.RowIndex].Cells[2].Value.ToString();
                txphone_member.Text = dgmember.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtmember.Text = dgmember.Rows[e.RowIndex].Cells[4].Value.ToString();
                btupdate_m.Enabled = true;
                btdelete_m.Enabled = true;
                btimport_m.Enabled = false;
            }
        }
    }
}
