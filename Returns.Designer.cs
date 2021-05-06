namespace Inventory_Management_System
{
    partial class Returns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Returns));
            this.btn_soreturns = new System.Windows.Forms.Button();
            this.btn_poreturns = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_soreturns
            // 
            this.btn_soreturns.BackColor = System.Drawing.Color.LightCyan;
            this.btn_soreturns.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_soreturns.BackgroundImage")));
            this.btn_soreturns.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soreturns.ForeColor = System.Drawing.Color.Transparent;
            this.btn_soreturns.Location = new System.Drawing.Point(84, 261);
            this.btn_soreturns.Name = "btn_soreturns";
            this.btn_soreturns.Size = new System.Drawing.Size(432, 122);
            this.btn_soreturns.TabIndex = 1;
            this.btn_soreturns.Text = "Sales Order Returns";
            this.btn_soreturns.UseVisualStyleBackColor = false;
            // 
            // btn_poreturns
            // 
            this.btn_poreturns.BackColor = System.Drawing.Color.LightCyan;
            this.btn_poreturns.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_poreturns.BackgroundImage")));
            this.btn_poreturns.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_poreturns.ForeColor = System.Drawing.Color.Transparent;
            this.btn_poreturns.Location = new System.Drawing.Point(84, 71);
            this.btn_poreturns.Name = "btn_poreturns";
            this.btn_poreturns.Size = new System.Drawing.Size(432, 122);
            this.btn_poreturns.TabIndex = 0;
            this.btn_poreturns.Text = "Purchase Order Returns";
            this.btn_poreturns.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventory_Management_System.Properties.Resources.Home_Button;
            this.pictureBox2.Location = new System.Drawing.Point(515, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(577, 490);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_soreturns);
            this.Controls.Add(this.btn_poreturns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Returns";
            this.Text = "Returns";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_poreturns;
        private System.Windows.Forms.Button btn_soreturns;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}