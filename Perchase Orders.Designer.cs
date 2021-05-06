namespace Inventory_Management_System
{
    partial class Purchase_Orders
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
            this.pb_quotreceived = new System.Windows.Forms.PictureBox();
            this.pb_purordinv = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quotreceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_purordinv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase Order Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quotation Received";
            // 
            // pb_quotreceived
            // 
            this.pb_quotreceived.Image = global::Inventory_Management_System.Properties.Resources.quotation;
            this.pb_quotreceived.Location = new System.Drawing.Point(167, 236);
            this.pb_quotreceived.Name = "pb_quotreceived";
            this.pb_quotreceived.Size = new System.Drawing.Size(178, 117);
            this.pb_quotreceived.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_quotreceived.TabIndex = 1;
            this.pb_quotreceived.TabStop = false;
            // 
            // pb_purordinv
            // 
            this.pb_purordinv.Image = global::Inventory_Management_System.Properties.Resources.invoice;
            this.pb_purordinv.Location = new System.Drawing.Point(167, 55);
            this.pb_purordinv.Name = "pb_purordinv";
            this.pb_purordinv.Size = new System.Drawing.Size(178, 117);
            this.pb_purordinv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_purordinv.TabIndex = 0;
            this.pb_purordinv.TabStop = false;
            this.pb_purordinv.Click += new System.EventHandler(this.pb_purordinv_Click);
            // 
            // Purchase_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_quotreceived);
            this.Controls.Add(this.pb_purordinv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Purchase_Orders";
            this.Text = "Purchase Orders";
            ((System.ComponentModel.ISupportInitialize)(this.pb_quotreceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_purordinv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_purordinv;
        private System.Windows.Forms.PictureBox pb_quotreceived;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}