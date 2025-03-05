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
            this.groupBox1.SuspendLayout();
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
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 571);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMember";
            this.Text = "FormMembers";
            this.Load += new System.EventHandler(this.FormMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}