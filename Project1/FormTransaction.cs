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
using System.Xml.Linq;

namespace Project1
{
    public partial class FormTransaction : Form
    {
        private Transactions transactions;
        private string BookID;
        private string MemberID;
        private string TransID;
        private int Fine = 0;
        private string TransRID;

        public FormTransaction()
        {
            InitializeComponent();
            transactions = new Transactions();
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
    
        private void FormTransaction_Load(object sender, EventArgs e)
        {
            lbtgl.Text = DateTime.Now.ToString();
            LoadDataBorrow();
            LoadDataRetur();
            LoadDataHistory();
            if (GlobalVariable.role != 99)
            {
                label4.Hide();
                btemployee.Hide();
            }

        }

        void LoadDataBorrow()
        {
            txsbook.Text = null;
            DataSet ds1 = new DataSet();
            ds1 = transactions.ReadBooks();
            dgbook.DataSource = ds1;
            dgbook.DataMember = "buku";
            txsmember.Text = null;
            DataSet ds2 = new DataSet();
            ds2 = transactions.ReadMembers();
            dgmember.DataSource = ds2;
            dgmember.DataMember = "mmbr";
        }

        void LoadDataRetur()
        {
            DataSet ds = new DataSet();
            ds = transactions.ReadReturn();
            dgretur.DataSource = ds;
            dgretur.DataMember = "retur";
        }

        void LoadDataHistory()
        {
            DataSet ds = new DataSet();
            ds = transactions.ReadHistory();
            dghistory.DataSource = ds;
            dghistory.DataMember = "hstr";
        }

        void ClearBorrow()
        {
            txbookbr.Text = null;
            txmemberbr.Text = null;
            nudays.Value = 0;
            BookID = null;
            MemberID = null;
            TransID = null;
            lbid.Text = "-";
        }

        void ClearRetur()
        {
            lbtridr.Text = "-";
            lbtitler.Text = "-";
            lbnamer.Text = "-";
            lbborrowr.Text = "-";
            lbduer.Text = "-";
            lbfiner.Text = "-";
            Fine = 0;
        }

        private void txsbook_TextChanged(object sender, EventArgs e)
        {
            dgbook.DataSource = transactions.SearchBooks(txsbook.Text);
        }
    
        private void txsmember_TextChanged(object sender, EventArgs e)
        {
            dgmember.DataSource = transactions.SearchMembers(txsmember.Text);
        }

        private void dgbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgbook.RowCount - 1)
            {
                txbookbr.Text = dgbook.Rows[e.RowIndex].Cells[1].Value.ToString();
                BookID = dgbook.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dgmember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgmember.RowCount - 1)
            {
                txmemberbr.Text = dgmember.Rows[e.RowIndex].Cells[1].Value.ToString();
                MemberID = dgmember.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btclearb_Click(object sender, EventArgs e)
        {
            txbookbr.Text = null;
            BookID = null;
        }

        private void btclearm_Click(object sender, EventArgs e)
        {
            txmemberbr.Text = null;
            MemberID = null;
        }

        private void btsubmitbr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TransID))
            {
                MessageBox.Show("Please generate tansaction number first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(BookID) || string.IsNullOrEmpty(MemberID))
            {
                MessageBox.Show("Please select a book and member first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int days = Convert.ToInt32(nudays.Value);
            DateTime due = DateTime.Now.AddDays(days);

            bool success = transactions.SubmitBorrow(BookID, MemberID, GlobalVariable.kode, due, TransID);
            if (success)
            {
                MessageBox.Show("Borrow transaction submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBorrow();
                LoadDataBorrow();
                LoadDataRetur();
                LoadDataHistory();
            }
            else
            {
                MessageBox.Show("Failed to submit borrow transaction!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btgid_Click(object sender, EventArgs e)
        {
            TransID = GlobalVariable.trid();
            lbid.Text = TransID;
        }

        private void dgretur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgretur.RowCount - 1)
            {
                TransRID = dgretur.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbtridr.Text = TransRID;
                lbtitler.Text = dgretur.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbnamer.Text = dgretur.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbborrowr.Text = dgretur.Rows[e.RowIndex].Cells[5].Value.ToString();
                lbduer.Text = dgretur.Rows[e.RowIndex].Cells[6].Value.ToString();

                // Calculate fine if book is overdue
                DateTime dueDate = DateTime.Parse(lbduer.Text);
                DateTime currentDate = DateTime.Now;

                if (currentDate > dueDate)
                {
                    TimeSpan overdueDays = currentDate - dueDate;
                    Fine = (int)overdueDays.TotalDays * 1000;
                    MessageBox.Show($"Late return fine: Rp {Fine:N0}", "Fine Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Fine = 0;
                }

                lbfiner.Text = Fine.ToString();
            }
        }

        private void btsubmitrt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TransRID))
            {
                MessageBox.Show("Please select data first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = transactions.ReturnBook(TransRID, Fine);
            if (success)
            {
                MessageBox.Show("Return transaction submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearRetur();
                LoadDataRetur();
                LoadDataBorrow();
                LoadDataHistory();
            }
            else
            {
                MessageBox.Show("Failed to submit return transaction!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txsretur_TextChanged(object sender, EventArgs e)
        {
            dgretur.DataSource = transactions.SearchReturn(txsretur.Text);
        }

        private void txshistory_TextChanged(object sender, EventArgs e)
        {
            dghistory.DataSource = transactions.SearchHistory(txshistory.Text);
        }
    }
}
