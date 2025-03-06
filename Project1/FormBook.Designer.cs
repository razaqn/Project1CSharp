namespace Project1
{
    partial class FormBook
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgbook = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nustock = new System.Windows.Forms.NumericUpDown();
            this.nuyearp = new System.Windows.Forms.NumericUpDown();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdeletebk = new System.Windows.Forms.Button();
            this.txauthor = new System.Windows.Forms.TextBox();
            this.txjudul = new System.Windows.Forms.TextBox();
            this.btimport = new System.Windows.Forms.Button();
            this.txkategori = new System.Windows.Forms.TextBox();
            this.txpublisher = new System.Windows.Forms.TextBox();
            this.txbkid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbook)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nustock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuyearp)).BeginInit();
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
            this.bttransaction.Size = new System.Drawing.Size(188, 34);
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
            this.btbook.BackColor = System.Drawing.Color.Wheat;
            this.btbook.Location = new System.Drawing.Point(6, 167);
            this.btbook.Name = "btbook";
            this.btbook.Size = new System.Drawing.Size(188, 33);
            this.btbook.TabIndex = 3;
            this.btbook.Text = "Books";
            this.btbook.UseVisualStyleBackColor = false;
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
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.dgbook);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(219, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 547);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "List Of Books";
            // 
            // dgbook
            // 
            this.dgbook.AllowUserToAddRows = false;
            this.dgbook.AllowUserToDeleteRows = false;
            this.dgbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbook.Location = new System.Drawing.Point(4, 32);
            this.dgbook.Margin = new System.Windows.Forms.Padding(4);
            this.dgbook.Name = "dgbook";
            this.dgbook.ReadOnly = true;
            this.dgbook.RowHeadersWidth = 51;
            this.dgbook.Size = new System.Drawing.Size(472, 510);
            this.dgbook.TabIndex = 0;
            this.dgbook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbook_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nustock);
            this.panel1.Controls.Add(this.nuyearp);
            this.panel1.Controls.Add(this.btupdate);
            this.panel1.Controls.Add(this.btdeletebk);
            this.panel1.Controls.Add(this.txauthor);
            this.panel1.Controls.Add(this.txjudul);
            this.panel1.Controls.Add(this.btimport);
            this.panel1.Controls.Add(this.txkategori);
            this.panel1.Controls.Add(this.txpublisher);
            this.panel1.Controls.Add(this.txbkid);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(707, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 550);
            this.panel1.TabIndex = 5;
            // 
            // nustock
            // 
            this.nustock.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nustock.Location = new System.Drawing.Point(35, 406);
            this.nustock.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nustock.Name = "nustock";
            this.nustock.Size = new System.Drawing.Size(229, 22);
            this.nustock.TabIndex = 18;
            // 
            // nuyearp
            // 
            this.nuyearp.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuyearp.Location = new System.Drawing.Point(35, 292);
            this.nuyearp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nuyearp.Name = "nuyearp";
            this.nuyearp.Size = new System.Drawing.Size(229, 22);
            this.nuyearp.TabIndex = 17;
            // 
            // btupdate
            // 
            this.btupdate.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.Location = new System.Drawing.Point(4, 494);
            this.btupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(129, 42);
            this.btupdate.TabIndex = 16;
            this.btupdate.Text = "UPDATE";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdeletebk
            // 
            this.btdeletebk.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeletebk.Location = new System.Drawing.Point(141, 494);
            this.btdeletebk.Margin = new System.Windows.Forms.Padding(4);
            this.btdeletebk.Name = "btdeletebk";
            this.btdeletebk.Size = new System.Drawing.Size(135, 42);
            this.btdeletebk.TabIndex = 15;
            this.btdeletebk.Text = "DELETE";
            this.btdeletebk.UseVisualStyleBackColor = true;
            this.btdeletebk.Click += new System.EventHandler(this.btdeletebk_Click);
            // 
            // txauthor
            // 
            this.txauthor.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txauthor.Location = new System.Drawing.Point(35, 184);
            this.txauthor.Margin = new System.Windows.Forms.Padding(4);
            this.txauthor.Name = "txauthor";
            this.txauthor.Size = new System.Drawing.Size(229, 22);
            this.txauthor.TabIndex = 8;
            // 
            // txjudul
            // 
            this.txjudul.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txjudul.Location = new System.Drawing.Point(35, 109);
            this.txjudul.Margin = new System.Windows.Forms.Padding(4);
            this.txjudul.Multiline = true;
            this.txjudul.Name = "txjudul";
            this.txjudul.Size = new System.Drawing.Size(229, 43);
            this.txjudul.TabIndex = 10;
            // 
            // btimport
            // 
            this.btimport.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimport.Location = new System.Drawing.Point(4, 450);
            this.btimport.Margin = new System.Windows.Forms.Padding(4);
            this.btimport.Name = "btimport";
            this.btimport.Size = new System.Drawing.Size(129, 36);
            this.btimport.TabIndex = 14;
            this.btimport.Text = "ADD";
            this.btimport.UseVisualStyleBackColor = true;
            this.btimport.Click += new System.EventHandler(this.btimport_Click);
            // 
            // txkategori
            // 
            this.txkategori.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txkategori.Location = new System.Drawing.Point(35, 350);
            this.txkategori.Margin = new System.Windows.Forms.Padding(4);
            this.txkategori.Name = "txkategori";
            this.txkategori.Size = new System.Drawing.Size(229, 22);
            this.txkategori.TabIndex = 12;
            // 
            // txpublisher
            // 
            this.txpublisher.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpublisher.Location = new System.Drawing.Point(35, 240);
            this.txpublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txpublisher.Name = "txpublisher";
            this.txpublisher.Size = new System.Drawing.Size(229, 22);
            this.txpublisher.TabIndex = 9;
            // 
            // txbkid
            // 
            this.txbkid.Enabled = false;
            this.txbkid.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbkid.Location = new System.Drawing.Point(35, 58);
            this.txbkid.Margin = new System.Windows.Forms.Padding(4);
            this.txbkid.Name = "txbkid";
            this.txbkid.Size = new System.Drawing.Size(229, 22);
            this.txbkid.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 220);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Publisher";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 273);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Year Published";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Author";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 387);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Title Book";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nustock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuyearp)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgbook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdeletebk;
        private System.Windows.Forms.TextBox txauthor;
        private System.Windows.Forms.TextBox txjudul;
        private System.Windows.Forms.Button btimport;
        private System.Windows.Forms.TextBox txkategori;
        private System.Windows.Forms.TextBox txpublisher;
        private System.Windows.Forms.TextBox txbkid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuyearp;
        private System.Windows.Forms.NumericUpDown nustock;
        private System.Windows.Forms.Button button1;
    }
}