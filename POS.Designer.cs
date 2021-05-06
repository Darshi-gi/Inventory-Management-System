using System;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    partial class pos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_cprice = new System.Windows.Forms.TextBox();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.txt_quantityreq = new System.Windows.Forms.TextBox();
            this.txt_fprice = new System.Windows.Forms.TextBox();
            this.txt_totsale = new System.Windows.Forms.TextBox();
            this.btn_addcart = new System.Windows.Forms.Button();
            this.btn_delcart = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.txt_tend = new System.Windows.Forms.TextBox();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pb_home = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_portno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Supplier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity Required";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 318);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Final Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 490);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Sale";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 490);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tendered";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 490);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Change";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 360);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.txt_cprice);
            this.panel1.Controls.Add(this.txt_supplier);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(549, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 105);
            this.panel1.TabIndex = 12;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(116, 14);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.txt_quantity.Multiline = true;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(78, 22);
            this.txt_quantity.TabIndex = 15;
            // 
            // txt_cprice
            // 
            this.txt_cprice.Location = new System.Drawing.Point(116, 40);
            this.txt_cprice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cprice.Multiline = true;
            this.txt_cprice.Name = "txt_cprice";
            this.txt_cprice.Size = new System.Drawing.Size(78, 22);
            this.txt_cprice.TabIndex = 16;
            // 
            // txt_supplier
            // 
            this.txt_supplier.Location = new System.Drawing.Point(116, 67);
            this.txt_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.txt_supplier.Multiline = true;
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(108, 22);
            this.txt_supplier.TabIndex = 17;
            // 
            // txt_quantityreq
            // 
            this.txt_quantityreq.Location = new System.Drawing.Point(664, 278);
            this.txt_quantityreq.Margin = new System.Windows.Forms.Padding(2);
            this.txt_quantityreq.Multiline = true;
            this.txt_quantityreq.Name = "txt_quantityreq";
            this.txt_quantityreq.Size = new System.Drawing.Size(78, 22);
            this.txt_quantityreq.TabIndex = 18;
            // 
            // txt_fprice
            // 
            this.txt_fprice.Location = new System.Drawing.Point(664, 316);
            this.txt_fprice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fprice.Multiline = true;
            this.txt_fprice.Name = "txt_fprice";
            this.txt_fprice.Size = new System.Drawing.Size(78, 22);
            this.txt_fprice.TabIndex = 19;
            // 
            // txt_totsale
            // 
            this.txt_totsale.Location = new System.Drawing.Point(247, 488);
            this.txt_totsale.Margin = new System.Windows.Forms.Padding(2);
            this.txt_totsale.Multiline = true;
            this.txt_totsale.Name = "txt_totsale";
            this.txt_totsale.Size = new System.Drawing.Size(120, 22);
            this.txt_totsale.TabIndex = 20;
            // 
            // btn_addcart
            // 
            this.btn_addcart.Location = new System.Drawing.Point(553, 356);
            this.btn_addcart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addcart.Name = "btn_addcart";
            this.btn_addcart.Size = new System.Drawing.Size(86, 21);
            this.btn_addcart.TabIndex = 21;
            this.btn_addcart.Text = "Add to Cart";
            this.btn_addcart.UseVisualStyleBackColor = true;
            this.btn_addcart.Click += new System.EventHandler(this.btn_addcart_Click);
            // 
            // btn_delcart
            // 
            this.btn_delcart.Location = new System.Drawing.Point(706, 356);
            this.btn_delcart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delcart.Name = "btn_delcart";
            this.btn_delcart.Size = new System.Drawing.Size(95, 21);
            this.btn_delcart.TabIndex = 22;
            this.btn_delcart.Text = "Delete from Cart";
            this.btn_delcart.UseVisualStyleBackColor = true;
            this.btn_delcart.Click += new System.EventHandler(this.delcart_btn_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(776, 481);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(90, 32);
            this.btn_checkout.TabIndex = 23;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            // 
            // txt_tend
            // 
            this.txt_tend.Location = new System.Drawing.Point(437, 488);
            this.txt_tend.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tend.Multiline = true;
            this.txt_tend.Name = "txt_tend";
            this.txt_tend.Size = new System.Drawing.Size(120, 22);
            this.txt_tend.TabIndex = 25;
            // 
            // txt_change
            // 
            this.txt_change.Location = new System.Drawing.Point(623, 488);
            this.txt_change.Margin = new System.Windows.Forms.Padding(2);
            this.txt_change.Multiline = true;
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(120, 22);
            this.txt_change.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Date";
            // 
            // pb_home
            // 
            this.pb_home.Image = global::Inventory_Management_System.Properties.Resources.Home_Button;
            this.pb_home.Location = new System.Drawing.Point(840, 10);
            this.pb_home.Margin = new System.Windows.Forms.Padding(2);
            this.pb_home.Name = "pb_home";
            this.pb_home.Size = new System.Drawing.Size(38, 28);
            this.pb_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_home.TabIndex = 42;
            this.pb_home.TabStop = false;
            this.pb_home.Click += new System.EventHandler(this.pb_home_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy_MM_dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(321, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // cmb_portno
            // 
            this.cmb_portno.FormattingEnabled = true;
            this.cmb_portno.Items.AddRange(new object[] {
            "X-205",
            "X-206",
            "X-207",
            "X-208",
            "X-209",
            "X-210",
            "X-213",
            "X-214",
            "X-215",
            "X-220",
            "X-307",
            "X-309",
            "X-310",
            "X-401",
            "X-402",
            "X-403",
            "X-1008",
            "X-1098",
            "X-1100",
            "X-1209",
            "X-1506",
            "X-2017",
            "X-2019",
            "X-2031",
            "X-2099",
            "X-2045A",
            "X-5014",
            "X-5015",
            "X-3118",
            "X-7093",
            "X-7128"});
            this.cmb_portno.Location = new System.Drawing.Point(112, 41);
            this.cmb_portno.Name = "cmb_portno";
            this.cmb_portno.Size = new System.Drawing.Size(121, 21);
            this.cmb_portno.TabIndex = 46;
            this.cmb_portno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.cmb_portno);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pb_home);
            this.Controls.Add(this.txt_change);
            this.Controls.Add(this.txt_tend);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_delcart);
            this.Controls.Add(this.btn_addcart);
            this.Controls.Add(this.txt_totsale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_fprice);
            this.Controls.Add(this.txt_quantityreq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pos";
            this.Load += new System.EventHandler(this.POS);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void delcart_btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_cprice;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.TextBox txt_quantityreq;
        private System.Windows.Forms.TextBox txt_fprice;
        private System.Windows.Forms.TextBox txt_totsale;
        private System.Windows.Forms.Button btn_addcart;
        private System.Windows.Forms.Button btn_delcart;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.TextBox txt_tend;
        private System.Windows.Forms.TextBox txt_change;
        private System.Windows.Forms.PictureBox pb_home;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_portno;
    }
}