namespace Inventory_Management_System
{
    partial class Sales_Order_Returns
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
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmb_reason = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txt_iname = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_portno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(95, 512);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(245, 43);
            this.btn_del.TabIndex = 28;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(95, 439);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(245, 43);
            this.btn_view.TabIndex = 27;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(95, 361);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(245, 43);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // cmb_reason
            // 
            this.cmb_reason.FormattingEnabled = true;
            this.cmb_reason.Items.AddRange(new object[] {
            "Damage",
            "Expire"});
            this.cmb_reason.Location = new System.Drawing.Point(95, 284);
            this.cmb_reason.Name = "cmb_reason";
            this.cmb_reason.Size = new System.Drawing.Size(245, 24);
            this.cmb_reason.TabIndex = 25;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(95, 122);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(245, 22);
            this.date.TabIndex = 24;
            // 
            // txt_iname
            // 
            this.txt_iname.Location = new System.Drawing.Point(95, 173);
            this.txt_iname.Name = "txt_iname";
            this.txt_iname.Size = new System.Drawing.Size(245, 22);
            this.txt_iname.TabIndex = 23;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(95, 232);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(94, 22);
            this.txt_Quantity.TabIndex = 22;
            // 
            // txt_portno
            // 
            this.txt_portno.Location = new System.Drawing.Point(95, 67);
            this.txt_portno.Name = "txt_portno";
            this.txt_portno.Size = new System.Drawing.Size(158, 22);
            this.txt_portno.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Port No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(504, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(834, 507);
            this.dataGridView1.TabIndex = 15;
            // 
            // Sales_Order_Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1350, 631);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_reason);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txt_iname);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_portno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Sales_Order_Returns";
            this.Text = "Sales Order Returns";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_reason;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txt_iname;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_portno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}