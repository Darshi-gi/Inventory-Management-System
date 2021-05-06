namespace Inventory_Management_System
{
    partial class Enter_Code
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
            this.txt_entercode = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.btn_sendcode = new System.Windows.Forms.Button();
            this.txt_enteremail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "If you have code,Enter and click confirm";
            // 
            // txt_entercode
            // 
            this.txt_entercode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entercode.Location = new System.Drawing.Point(86, 198);
            this.txt_entercode.Multiline = true;
            this.txt_entercode.Name = "txt_entercode";
            this.txt_entercode.Size = new System.Drawing.Size(109, 29);
            this.txt_entercode.TabIndex = 5;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(86, 242);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(109, 30);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
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
            // btn_sendcode
            // 
            this.btn_sendcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sendcode.Location = new System.Drawing.Point(86, 105);
            this.btn_sendcode.Name = "btn_sendcode";
            this.btn_sendcode.Size = new System.Drawing.Size(109, 32);
            this.btn_sendcode.TabIndex = 9;
            this.btn_sendcode.Text = "Send Code";
            this.btn_sendcode.UseVisualStyleBackColor = true;
            this.btn_sendcode.Click += new System.EventHandler(this.btn_sendcode_Click);
            // 
            // txt_enteremail
            // 
            this.txt_enteremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enteremail.Location = new System.Drawing.Point(86, 56);
            this.txt_enteremail.Multiline = true;
            this.txt_enteremail.Name = "txt_enteremail";
            this.txt_enteremail.Size = new System.Drawing.Size(272, 30);
            this.txt_enteremail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Your E mail For Get Code";
            // 
            // Enter_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 290);
            this.Controls.Add(this.btn_sendcode);
            this.Controls.Add(this.txt_enteremail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_entercode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Enter_Code";
            this.Text = "Enter Code";
            this.Load += new System.EventHandler(this.Enter_Code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_entercode;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_sendcode;
        private System.Windows.Forms.TextBox txt_enteremail;
        private System.Windows.Forms.Label label2;
    }
}