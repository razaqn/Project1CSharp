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
            if (GlobalVariable.role != 99)
            {
                label4.Hide();
                btemployee.Hide();
            }
        }
    }
}
