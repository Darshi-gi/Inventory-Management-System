namespace Inventory_Management_System
{
    partial class New_Password
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
            this.txt_newpw = new System.Windows.Forms.TextBox();
            this.txt_confirmnewpw = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.pb_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirm Password";
            // 
            // txt_newpw
            // 
            this.txt_newpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpw.Location = new System.Drawing.Point(120, 48);
            this.txt_newpw.Name = "txt_newpw";
            this.txt_newpw.PasswordChar = '*';
            this.txt_newpw.Size = new System.Drawing.Size(307, 24);
            this.txt_newpw.TabIndex = 6;
            this.txt_newpw.TextChanged += new System.EventHandler(this.txt_newpw_TextChanged);
            // 
            // txt_confirmnewpw
            // 
            this.txt_confirmnewpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmnewpw.Location = new System.Drawing.Point(120, 115);
            this.txt_confirmnewpw.Name = "txt_confirmnewpw";
            this.txt_confirmnewpw.PasswordChar = '*';
            this.txt_confirmnewpw.Size = new System.Drawing.Size(307, 24);
            this.txt_confirmnewpw.TabIndex = 7;
            this.txt_confirmnewpw.TextChanged += new System.EventHandler(this.txt_confirmnewpw_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(214, 161);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 30);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pb_back
            // 
            this.pb_back.Image = global::Inventory_Management_System.Properties.Resources.Back_Button;
            this.pb_back.Location = new System.Drawing.Point(12, 12);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(30, 25);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_back.TabIndex = 3;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // New_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 203);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_confirmnewpw);
            this.Controls.Add(this.txt_newpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "New_Password";
            this.Text = "New Password";
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_newpw;
        private System.Windows.Forms.TextBox txt_confirmnewpw;
        private System.Windows.Forms.Button btn_save;
    }
}