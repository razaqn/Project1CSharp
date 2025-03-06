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
            this.dtmember = new System.Windows.Forms.DateTimePicker();
            this.btupdate_m = new System.Windows.Forms.Button();
            this.btimport_m = new System.Windows.Forms.Button();
            this.btdelete_m = new System.Windows.Forms.Button();
            this.txemail_member = new System.Windows.Forms.TextBox();
            this.txid_member = new System.Windows.Forms.TextBox();
            this.txphone_member = new System.Windows.Forms.TextBox();
            this.txnama_member = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgmember = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 547);
            this.groupBox1.TabIndex = 1;
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
            this.btemployee.Location = new System.Drawing.Point(6, 303);
            this.btemployee.Name = "btemployee";
            this.btemployee.Size = new System.Drawing.Size(188, 33);
            this.btemployee.TabIndex = 8;
            this.btemployee.Text = "Employee";
            this.btemployee.UseVisualStyleBackColor = true;
            this.btemployee.Click += new System.EventHandler(this.btemployee_Click);
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
            this.btmember.BackColor = System.Drawing.Color.Wheat;
            this.btmember.Location = new System.Drawing.Point(6, 128);
            this.btmember.Name = "btmember";
            this.btmember.Size = new System.Drawing.Size(188, 33);
            this.btmember.TabIndex = 2;
            this.btmember.Text = "Members";
            this.btmember.UseVisualStyleBackColor = false;
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
            // dtmember
            // 
            this.dtmember.Location = new System.Drawing.Point(481, 118);
            this.dtmember.Margin = new System.Windows.Forms.Padding(4);
            this.dtmember.Name = "dtmember";
            this.dtmember.Size = new System.Drawing.Size(247, 22);
            this.dtmember.TabIndex = 30;
            // 
            // btupdate_m
            // 
            this.btupdate_m.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate_m.Location = new System.Drawing.Point(874, 42);
            this.btupdate_m.Margin = new System.Windows.Forms.Padding(4);
            this.btupdate_m.Name = "btupdate_m";
            this.btupdate_m.Size = new System.Drawing.Size(104, 39);
            this.btupdate_m.TabIndex = 29;
            this.btupdate_m.Text = "Update";
            this.btupdate_m.UseVisualStyleBackColor = true;
            this.btupdate_m.Click += new System.EventHandler(this.btupdate_m_Click);
            // 
            // btimport_m
            // 
            this.btimport_m.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimport_m.Location = new System.Drawing.Point(746, 41);
            this.btimport_m.Margin = new System.Windows.Forms.Padding(4);
            this.btimport_m.Name = "btimport_m";
            this.btimport_m.Size = new System.Drawing.Size(108, 41);
            this.btimport_m.TabIndex = 28;
            this.btimport_m.Text = "Add";
            this.btimport_m.UseVisualStyleBackColor = true;
            this.btimport_m.Click += new System.EventHandler(this.btimport_m_Click);
            // 
            // btdelete_m
            // 
            this.btdelete_m.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete_m.Location = new System.Drawing.Point(874, 101);
            this.btdelete_m.Margin = new System.Windows.Forms.Padding(4);
            this.btdelete_m.Name = "btdelete_m";
            this.btdelete_m.Size = new System.Drawing.Size(104, 39);
            this.btdelete_m.TabIndex = 27;
            this.btdelete_m.Text = "Delete";
            this.btdelete_m.UseVisualStyleBackColor = true;
            this.btdelete_m.Click += new System.EventHandler(this.btdelete_m_Click);
            // 
            // txemail_member
            // 
            this.txemail_member.Location = new System.Drawing.Point(244, 118);
            this.txemail_member.Margin = new System.Windows.Forms.Padding(4);
            this.txemail_member.Name = "txemail_member";
            this.txemail_member.Size = new System.Drawing.Size(228, 22);
            this.txemail_member.TabIndex = 26;
            // 
            // txid_member
            // 
            this.txid_member.Enabled = false;
            this.txid_member.Location = new System.Drawing.Point(244, 60);
            this.txid_member.Margin = new System.Windows.Forms.Padding(4);
            this.txid_member.Name = "txid_member";
            this.txid_member.Size = new System.Drawing.Size(88, 22);
            this.txid_member.TabIndex = 25;
            // 
            // txphone_member
            // 
            this.txphone_member.Location = new System.Drawing.Point(533, 60);
            this.txphone_member.Margin = new System.Windows.Forms.Padding(4);
            this.txphone_member.Name = "txphone_member";
            this.txphone_member.Size = new System.Drawing.Size(195, 22);
            this.txphone_member.TabIndex = 24;
            // 
            // txnama_member
            // 
            this.txnama_member.Location = new System.Drawing.Point(341, 60);
            this.txnama_member.Margin = new System.Windows.Forms.Padding(4);
            this.txnama_member.Name = "txnama_member";
            this.txnama_member.Size = new System.Drawing.Size(183, 22);
            this.txnama_member.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Email Member";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Join Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Member ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nama Member";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.dgmember);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(216, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 411);
            this.panel1.TabIndex = 17;
            // 
            // dgmember
            // 
            this.dgmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmember.Location = new System.Drawing.Point(4, 39);
            this.dgmember.Margin = new System.Windows.Forms.Padding(4);
            this.dgmember.Name = "dgmember";
            this.dgmember.RowHeadersWidth = 51;
            this.dgmember.Size = new System.Drawing.Size(797, 366);
            this.dgmember.TabIndex = 0;
            this.dgmember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmember_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "List Of Members";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(746, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 31;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 571);
            this.Controls.Add(this.button1);
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
            this.Name = "FormMember";
            this.Text = "FormMembers";
            this.Load += new System.EventHandler(this.FormMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtmember;
        private System.Windows.Forms.Button btupdate_m;
        private System.Windows.Forms.Button btimport_m;
        private System.Windows.Forms.Button btdelete_m;
        private System.Windows.Forms.TextBox txemail_member;
        private System.Windows.Forms.TextBox txid_member;
        private System.Windows.Forms.TextBox txphone_member;
        private System.Windows.Forms.TextBox txnama_member;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgmember;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}