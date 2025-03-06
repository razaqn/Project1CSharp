namespace Project1
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btlogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btemployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bttransaction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btbook = new System.Windows.Forms.Button();
            this.btmember = new System.Windows.Forms.Button();
            this.btdashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.txpw = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txphone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dgemployee = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.btlogout);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btemployee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bttransaction);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btbook);
            this.groupBox1.Controls.Add(this.btmember);
            this.groupBox1.Controls.Add(this.btdashboard);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 547);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(6, 498);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(188, 43);
            this.btlogout.TabIndex = 11;
            this.btlogout.Text = "Logout";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "User";
            // 
            // btemployee
            // 
            this.btemployee.BackColor = System.Drawing.Color.Wheat;
            this.btemployee.Location = new System.Drawing.Point(6, 303);
            this.btemployee.Name = "btemployee";
            this.btemployee.Size = new System.Drawing.Size(188, 33);
            this.btemployee.TabIndex = 8;
            this.btemployee.Text = "Employee";
            this.btemployee.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Transaction";
            // 
            // bttransaction
            // 
            this.bttransaction.Location = new System.Drawing.Point(6, 236);
            this.bttransaction.Name = "bttransaction";
            this.bttransaction.Size = new System.Drawing.Size(188, 33);
            this.bttransaction.TabIndex = 5;
            this.bttransaction.Text = "Borrow and Return";
            this.bttransaction.UseVisualStyleBackColor = true;
            this.bttransaction.Click += new System.EventHandler(this.bttransaction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item";
            // 
            // btbook
            // 
            this.btbook.Location = new System.Drawing.Point(6, 167);
            this.btbook.Name = "btbook";
            this.btbook.Size = new System.Drawing.Size(188, 33);
            this.btbook.TabIndex = 3;
            this.btbook.Text = "Books";
            this.btbook.UseVisualStyleBackColor = true;
            this.btbook.Click += new System.EventHandler(this.btbook_Click);
            // 
            // btmember
            // 
            this.btmember.Location = new System.Drawing.Point(6, 128);
            this.btmember.Name = "btmember";
            this.btmember.Size = new System.Drawing.Size(188, 33);
            this.btmember.TabIndex = 2;
            this.btmember.Text = "Members";
            this.btmember.UseVisualStyleBackColor = true;
            this.btmember.Click += new System.EventHandler(this.btmember_Click);
            // 
            // btdashboard
            // 
            this.btdashboard.Location = new System.Drawing.Point(6, 51);
            this.btdashboard.Name = "btdashboard";
            this.btdashboard.Size = new System.Drawing.Size(188, 43);
            this.btdashboard.TabIndex = 1;
            this.btdashboard.Text = "Dashboard";
            this.btdashboard.UseVisualStyleBackColor = true;
            this.btdashboard.Click += new System.EventHandler(this.btdashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btdelete);
            this.panel2.Controls.Add(this.btupdate);
            this.panel2.Controls.Add(this.btadd);
            this.panel2.Controls.Add(this.txpw);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txname);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txphone);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txid);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txemail);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(219, 313);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 245);
            this.panel2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID Employee";
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(523, 174);
            this.btdelete.Margin = new System.Windows.Forms.Padding(4);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(153, 50);
            this.btdelete.TabIndex = 14;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(331, 174);
            this.btupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(153, 50);
            this.btupdate.TabIndex = 13;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(139, 174);
            this.btadd.Margin = new System.Windows.Forms.Padding(4);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(153, 50);
            this.btadd.TabIndex = 12;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // txpw
            // 
            this.txpw.Location = new System.Drawing.Point(139, 127);
            this.txpw.Margin = new System.Windows.Forms.Padding(4);
            this.txpw.Name = "txpw";
            this.txpw.Size = new System.Drawing.Size(181, 22);
            this.txpw.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Password";
            // 
            // txname
            // 
            this.txname.Location = new System.Drawing.Point(139, 81);
            this.txname.Margin = new System.Windows.Forms.Padding(4);
            this.txname.Name = "txname";
            this.txname.Size = new System.Drawing.Size(181, 22);
            this.txname.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone Number";
            // 
            // txphone
            // 
            this.txphone.Location = new System.Drawing.Point(472, 81);
            this.txphone.Margin = new System.Windows.Forms.Padding(4);
            this.txphone.Name = "txphone";
            this.txphone.Size = new System.Drawing.Size(181, 22);
            this.txphone.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name";
            // 
            // txid
            // 
            this.txid.Location = new System.Drawing.Point(139, 37);
            this.txid.Margin = new System.Windows.Forms.Padding(4);
            this.txid.Name = "txid";
            this.txid.Size = new System.Drawing.Size(181, 22);
            this.txid.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // txemail
            // 
            this.txemail.Location = new System.Drawing.Point(472, 37);
            this.txemail.Margin = new System.Windows.Forms.Padding(4);
            this.txemail.Name = "txemail";
            this.txemail.Size = new System.Drawing.Size(181, 22);
            this.txemail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dgemployee);
            this.panel1.Location = new System.Drawing.Point(219, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 294);
            this.panel1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Employee\'s Data";
            // 
            // dgemployee
            // 
            this.dgemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgemployee.Location = new System.Drawing.Point(4, 71);
            this.dgemployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgemployee.Name = "dgemployee";
            this.dgemployee.RowHeadersWidth = 51;
            this.dgemployee.Size = new System.Drawing.Size(784, 219);
            this.dgemployee.TabIndex = 0;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgemployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btemployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbook;
        private System.Windows.Forms.Button btmember;
        private System.Windows.Forms.Button btdashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txpw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txphone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgemployee;
    }
}