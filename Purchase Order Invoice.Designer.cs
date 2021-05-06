namespace Inventory_Management_System
{
    partial class Purchase_Order_Invoice
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
            this.btn_additem = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_measure = new System.Windows.Forms.ComboBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_iname = new System.Windows.Forms.TextBox();
            this.txt_portno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_additem
            // 
            this.btn_additem.Location = new System.Drawing.Point(800, 116);
            this.btn_additem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(76, 28);
            this.btn_additem.TabIndex = 0;
            this.btn_additem.Text = "Add Item";
            this.btn_additem.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(800, 230);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(76, 28);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(800, 290);
            this.btn_print.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(76, 28);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(42, 7);
            this.date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(188, 20);
            this.date.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(711, 239);
            this.dataGridView1.TabIndex = 52;
            // 
            // cmb_measure
            // 
            this.cmb_measure.FormattingEnabled = true;
            this.cmb_measure.Items.AddRange(new object[] {
            "4 L x 4 pcs",
            "650 ml x 12 pcs",
            "500 ml x 12 pcs",
            "475 ml x 12 pcs",
            "450 ml x 12 pcs",
            "443 ml x 12 pcs",
            "354 ml x 12 pcs",
            "250 ml x 12 pcs",
            "36 ml x 20 x 4 pcs",
            "3.785 Kg x 6 pcs",
            "230 g x 12 pcs"});
            this.cmb_measure.Location = new System.Drawing.Point(817, 46);
            this.cmb_measure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_measure.Name = "cmb_measure";
            this.cmb_measure.Size = new System.Drawing.Size(111, 21);
            this.cmb_measure.TabIndex = 51;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(577, 46);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_quantity.Multiline = true;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(128, 21);
            this.txt_quantity.TabIndex = 50;
            // 
            // txt_iname
            // 
            this.txt_iname.Location = new System.Drawing.Point(292, 46);
            this.txt_iname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_iname.Multiline = true;
            this.txt_iname.Name = "txt_iname";
            this.txt_iname.Size = new System.Drawing.Size(186, 21);
            this.txt_iname.TabIndex = 49;
            // 
            // txt_portno
            // 
            this.txt_portno.Location = new System.Drawing.Point(66, 46);
            this.txt_portno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_portno.Multiline = true;
            this.txt_portno.Name = "txt_portno";
            this.txt_portno.Size = new System.Drawing.Size(128, 21);
            this.txt_portno.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(742, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Measurement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Port No";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_Management_System.Properties.Resources.Home_Button;
            this.pictureBox1.Location = new System.Drawing.Point(991, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 58;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 21);
            this.textBox1.TabIndex = 62;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 9);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 21);
            this.textBox2.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "User";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventory_Management_System.Properties.Resources.Home_Button;
            this.pictureBox2.Location = new System.Drawing.Point(904, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Purchase_Order_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(944, 377);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.date);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_measure);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_iname);
            this.Controls.Add(this.txt_portno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_additem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Purchase_Order_Invoice";
            this.Text = "Purchase Order Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_additem;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_measure;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_iname;
        private System.Windows.Forms.TextBox txt_portno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}