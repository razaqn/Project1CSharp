namespace Project1
{
    partial class FormMember
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgmember = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txnama_member = new System.Windows.Forms.TextBox();
            this.txphone_member = new System.Windows.Forms.TextBox();
            this.txid_member = new System.Windows.Forms.TextBox();
            this.txemail_member = new System.Windows.Forms.TextBox();
            this.btdelete_m = new System.Windows.Forms.Button();
            this.btimport_m = new System.Windows.Forms.Button();
            this.btupdate_m = new System.Windows.Forms.Button();
            this.dtmember = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmember)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(4, 405);
            this.btlogout.Margin = new System.Windows.Forms.Padding(2);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(141, 35);
            this.btlogout.TabIndex = 11;
            this.btlogout.Text = "Logout";
            this.btlogout.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User";
            // 
            // btemployee
            // 
            this.btemployee.Location = new System.Drawing.Point(4, 246);
            this.btemployee.Margin = new System.Windows.Forms.Padding(2);
            this.btemployee.Name = "btemployee";
            this.btemployee.Size = new System.Drawing.Size(141, 27);
            this.btemployee.TabIndex = 8;
            this.btemployee.Text = "Employee";
            this.btemployee.UseVisualStyleBackColor = true;
            this.btemployee.Click += new System.EventHandler(this.btemployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Transaction";
            // 
            // bttransaction
            // 
            this.bttransaction.Location = new System.Drawing.Point(4, 192);
            this.bttransaction.Margin = new System.Windows.Forms.Padding(2);
            this.bttransaction.Name = "bttransaction";
            this.bttransaction.Size = new System.Drawing.Size(141, 27);
            this.bttransaction.TabIndex = 5;
            this.bttransaction.Text = "Borrow and Return";
            this.bttransaction.UseVisualStyleBackColor = true;
            this.bttransaction.Click += new System.EventHandler(this.bttransaction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item";
            // 
            // btbook
            // 
            this.btbook.Location = new System.Drawing.Point(4, 136);
            this.btbook.Margin = new System.Windows.Forms.Padding(2);
            this.btbook.Name = "btbook";
            this.btbook.Size = new System.Drawing.Size(141, 27);
            this.btbook.TabIndex = 3;
            this.btbook.Text = "Books";
            this.btbook.UseVisualStyleBackColor = true;
            this.btbook.Click += new System.EventHandler(this.btbook_Click);
            // 
            // btmember
            // 
            this.btmember.BackColor = System.Drawing.Color.Wheat;
            this.btmember.Location = new System.Drawing.Point(4, 104);
            this.btmember.Margin = new System.Windows.Forms.Padding(2);
            this.btmember.Name = "btmember";
            this.btmember.Size = new System.Drawing.Size(141, 27);
            this.btmember.TabIndex = 2;
            this.btmember.Text = "Members";
            this.btmember.UseVisualStyleBackColor = false;
            // 
            // btdashboard
            // 
            this.btdashboard.Location = new System.Drawing.Point(4, 41);
            this.btdashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btdashboard.Name = "btdashboard";
            this.btdashboard.Size = new System.Drawing.Size(141, 35);
            this.btdashboard.TabIndex = 1;
            this.btdashboard.Text = "Dashboard";
            this.btdashboard.UseVisualStyleBackColor = true;
            this.btdashboard.Click += new System.EventHandler(this.btdashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library App";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.dgmember);
            this.panel1.Location = new System.Drawing.Point(164, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 286);
            this.panel1.TabIndex = 2;
            // 
            // dgmember
            // 
            this.dgmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmember.Location = new System.Drawing.Point(3, 3);
            this.dgmember.Name = "dgmember";
            this.dgmember.Size = new System.Drawing.Size(598, 269);
            this.dgmember.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama Member";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Member ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(363, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Join Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(182, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email Member";
            // 
            // txnama_member
            // 
            this.txnama_member.Location = new System.Drawing.Point(258, 45);
            this.txnama_member.Name = "txnama_member";
            this.txnama_member.Size = new System.Drawing.Size(138, 20);
            this.txnama_member.TabIndex = 8;
            this.txnama_member.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txphone_member
            // 
            this.txphone_member.Location = new System.Drawing.Point(402, 45);
            this.txphone_member.Name = "txphone_member";
            this.txphone_member.Size = new System.Drawing.Size(147, 20);
            this.txphone_member.TabIndex = 10;
            // 
            // txid_member
            // 
            this.txid_member.Location = new System.Drawing.Point(185, 45);
            this.txid_member.Name = "txid_member";
            this.txid_member.Size = new System.Drawing.Size(67, 20);
            this.txid_member.TabIndex = 11;
            // 
            // txemail_member
            // 
            this.txemail_member.Location = new System.Drawing.Point(185, 92);
            this.txemail_member.Name = "txemail_member";
            this.txemail_member.Size = new System.Drawing.Size(172, 20);
            this.txemail_member.TabIndex = 12;
            // 
            // btdelete_m
            // 
            this.btdelete_m.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete_m.Location = new System.Drawing.Point(658, 87);
            this.btdelete_m.Name = "btdelete_m";
            this.btdelete_m.Size = new System.Drawing.Size(78, 54);
            this.btdelete_m.TabIndex = 13;
            this.btdelete_m.Text = "Delete";
            this.btdelete_m.UseVisualStyleBackColor = true;
            this.btdelete_m.Click += new System.EventHandler(this.btdelete_m_Click);
            // 
            // btimport_m
            // 
            this.btimport_m.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimport_m.Location = new System.Drawing.Point(562, 29);
            this.btimport_m.Name = "btimport_m";
            this.btimport_m.Size = new System.Drawing.Size(174, 45);
            this.btimport_m.TabIndex = 14;
            this.btimport_m.Text = "IMPORT";
            this.btimport_m.UseVisualStyleBackColor = true;
            this.btimport_m.Click += new System.EventHandler(this.btimport_m_Click);
            // 
            // btupdate_m
            // 
            this.btupdate_m.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate_m.Location = new System.Drawing.Point(562, 87);
            this.btupdate_m.Name = "btupdate_m";
            this.btupdate_m.Size = new System.Drawing.Size(81, 54);
            this.btupdate_m.TabIndex = 15;
            this.btupdate_m.Text = "Update";
            this.btupdate_m.UseVisualStyleBackColor = true;
            this.btupdate_m.Click += new System.EventHandler(this.btupdate_m_Click);
            // 
            // dtmember
            // 
            this.dtmember.Location = new System.Drawing.Point(363, 92);
            this.dtmember.Name = "dtmember";
            this.dtmember.Size = new System.Drawing.Size(186, 20);
            this.dtmember.TabIndex = 16;
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 464);
            this.Controls.Add(this.dtmember);
            this.Controls.Add(this.btupdate_m);
            this.Controls.Add(this.btimport_m);
            this.Controls.Add(this.btdelete_m);
            this.Controls.Add(this.txemail_member);
            this.Controls.Add(this.txid_member);
            this.Controls.Add(this.txphone_member);
            this.Controls.Add(this.txnama_member);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMember";
            this.Text = "FormMembers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgmember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgmember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txnama_member;
        private System.Windows.Forms.TextBox txphone_member;
        private System.Windows.Forms.TextBox txid_member;
        private System.Windows.Forms.TextBox txemail_member;
        private System.Windows.Forms.Button btdelete_m;
        private System.Windows.Forms.Button btimport_m;
        private System.Windows.Forms.Button btupdate_m;
        private System.Windows.Forms.DateTimePicker dtmember;
    }
}