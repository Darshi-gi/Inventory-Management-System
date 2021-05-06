namespace Inventory_Management_System
{
    partial class Manage_Suppliers
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.btn_disp = new System.Windows.Forms.Button();
            this.btn_addsupplier = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_home = new System.Windows.Forms.PictureBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(845, 378);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(204, 25);
            this.txt_email.TabIndex = 37;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(845, 336);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(204, 25);
            this.txt_contact.TabIndex = 36;
            // 
            // txt_sname
            // 
            this.txt_sname.Location = new System.Drawing.Point(845, 138);
            this.txt_sname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sname.Multiline = true;
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(204, 25);
            this.txt_sname.TabIndex = 34;
            // 
            // txt_sid
            // 
            this.txt_sid.Location = new System.Drawing.Point(845, 92);
            this.txt_sid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sid.Multiline = true;
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.Size = new System.Drawing.Size(204, 25);
            this.txt_sid.TabIndex = 33;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(992, 444);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(56, 23);
            this.btn_del.TabIndex = 31;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(922, 444);
            this.btn_upd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(56, 23);
            this.btn_upd.TabIndex = 30;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // btn_disp
            // 
            this.btn_disp.Location = new System.Drawing.Point(853, 444);
            this.btn_disp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_disp.Name = "btn_disp";
            this.btn_disp.Size = new System.Drawing.Size(56, 23);
            this.btn_disp.TabIndex = 29;
            this.btn_disp.Text = "Display";
            this.btn_disp.UseVisualStyleBackColor = true;
            this.btn_disp.Click += new System.EventHandler(this.btn_disp_Click);
            // 
            // btn_addsupplier
            // 
            this.btn_addsupplier.Location = new System.Drawing.Point(754, 444);
            this.btn_addsupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addsupplier.Name = "btn_addsupplier";
            this.btn_addsupplier.Size = new System.Drawing.Size(80, 23);
            this.btn_addsupplier.TabIndex = 28;
            this.btn_addsupplier.Text = "Add Supplier";
            this.btn_addsupplier.UseVisualStyleBackColor = true;
            this.btn_addsupplier.Click += new System.EventHandler(this.btn_addsupplier_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(753, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "E mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 339);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Supplier ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(886, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Supplier Informattion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Supplier List";
            // 
            // pb_home
            // 
            this.pb_home.Image = global::Inventory_Management_System.Properties.Resources.Home_Button;
            this.pb_home.Location = new System.Drawing.Point(1029, 10);
            this.pb_home.Margin = new System.Windows.Forms.Padding(2);
            this.pb_home.Name = "pb_home";
            this.pb_home.Size = new System.Drawing.Size(38, 28);
            this.pb_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_home.TabIndex = 40;
            this.pb_home.TabStop = false;
            this.pb_home.Click += new System.EventHandler(this.pb_home_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(845, 208);
            this.txt_address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(204, 67);
            this.txt_address.TabIndex = 41;
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(845, 294);
            this.txt_country.Margin = new System.Windows.Forms.Padding(2);
            this.txt_country.Multiline = true;
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(204, 25);
            this.txt_country.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(753, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(752, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Date";
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.Default;
            this.date.Location = new System.Drawing.Point(845, 176);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(204, 20);
            this.date.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 372);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Manage_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1076, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.pb_home);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.txt_sid);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.btn_disp);
            this.Controls.Add(this.btn_addsupplier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manage_Suppliers";
            this.Text = "Manage Suppliers";
            this.Load += new System.EventHandler(this.Manage_Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_home;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.TextBox txt_sid;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_disp;
        private System.Windows.Forms.Button btn_addsupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}