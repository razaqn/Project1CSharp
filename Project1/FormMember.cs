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
    public partial class FormMember : Form
    {
        public FormMember()
        {
            InitializeComponent();
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
            if (GlobalVariable.role != 99)
            {
                label4.Hide();
                btemployee.Hide();
            }
        }

        private void btimport_m_Click(object sender, EventArgs e)
        {
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
    }
}
