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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.EmpID = txcode.Text;
            auth.EmpPassword = txpass.Text;
            auth.doLogin();
            if (auth.HasilLogin == 1)
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
        }
    }
}
