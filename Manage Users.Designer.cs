namespace Inventory_Management_System
{
    partial class Manage_Users
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_home = new System.Windows.Forms.PictureBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1196, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Informattion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1045, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1045, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1045, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "User Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1045, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1045, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "E mail";
            // 
            // btn_adduser
            // 
            this.btn_adduser.Location = new System.Drawing.Point(1019, 530);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(86, 28);
            this.btn_adduser.TabIndex = 7;
            this.btn_adduser.Text = "Add User";
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(1234, 530);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(75, 28);
            this.btn_upd.TabIndex = 9;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(1336, 530);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 28);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_nic
            // 
            this.txt_nic.Location = new System.Drawing.Point(1140, 92);
            this.txt_nic.Multiline = true;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(271, 30);
            this.txt_nic.TabIndex = 13;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(1140, 142);
            this.txt_fname.Multiline = true;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(271, 30);
            this.txt_fname.TabIndex = 14;
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(1140, 335);
            this.txt_uname.Multiline = true;
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(271, 30);
            this.txt_uname.TabIndex = 15;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(1140, 245);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(271, 30);
            this.txt_contact.TabIndex = 16;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(1140, 387);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(271, 30);
            this.txt_email.TabIndex = 17;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(1140, 438);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(271, 80);
            this.txt_address.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1045, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Address";
            // 
            // pb_home
            // 
            this.pb_home.Image = global::Inventory_Management_System.Properties.Resources.Home_Button;
            this.pb_home.Location = new System.Drawing.Point(1361, 12);
            this.pb_home.Name = "pb_home";
            this.pb_home.Size = new System.Drawing.Size(50, 35);
            this.pb_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_home.TabIndex = 20;
            this.pb_home.TabStop = false;
            this.pb_home.Click += new System.EventHandler(this.pb_home_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(1140, 198);
            this.txt_lname.Multiline = true;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(271, 30);
            this.txt_lname.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1045, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Last Name";
            // 
            // dob
            // 
            this.dob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dob.Location = new System.Drawing.Point(1140, 291);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(271, 22);
            this.dob.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1045, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Date Of Birth";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 423);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(1127, 530);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(82, 28);
            this.btn_view.TabIndex = 26;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // Manage_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1423, 603);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.pb_home);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Manage_Users";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.Manage_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_home;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_view;
    }
}