namespace Inventory_Management_System
{
    partial class Login
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
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lnklbl_changepw = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnklbl_signup = new System.Windows.Forms.LinkLabel();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txt_uname
            // 
            this.txt_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uname.Location = new System.Drawing.Point(480, 270);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(190, 27);
            this.txt_uname.TabIndex = 5;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(480, 342);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(190, 27);
            this.txt_password.TabIndex = 6;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lnklbl_changepw
            // 
            this.lnklbl_changepw.AutoSize = true;
            this.lnklbl_changepw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklbl_changepw.Location = new System.Drawing.Point(403, 465);
            this.lnklbl_changepw.Name = "lnklbl_changepw";
            this.lnklbl_changepw.Size = new System.Drawing.Size(130, 17);
            this.lnklbl_changepw.TabIndex = 7;
            this.lnklbl_changepw.TabStop = true;
            this.lnklbl_changepw.Text = "Change Password?";
            this.lnklbl_changepw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_changepw_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "or";
            // 
            // lnklbl_signup
            // 
            this.lnklbl_signup.AutoSize = true;
            this.lnklbl_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklbl_signup.Location = new System.Drawing.Point(568, 464);
            this.lnklbl_signup.Name = "lnklbl_signup";
            this.lnklbl_signup.Size = new System.Drawing.Size(52, 17);
            this.lnklbl_signup.TabIndex = 9;
            this.lnklbl_signup.TabStop = true;
            this.lnklbl_signup.Text = "Signup";
            this.lnklbl_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_signup_LinkClicked);
            // 
            // pb_login
            // 
            this.pb_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_login.Image = global::Inventory_Management_System.Properties.Resources.loging_button;
            this.pb_login.Location = new System.Drawing.Point(461, 391);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(100, 50);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_login.TabIndex = 10;
            this.pb_login.TabStop = false;
            this.pb_login.Click += new System.EventHandler(this.pb_login_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Inventory_Management_System.Properties.Resources.Password;
            this.pictureBox3.Location = new System.Drawing.Point(323, 333);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventory_Management_System.Properties.Resources.User_Name;
            this.pictureBox2.Location = new System.Drawing.Point(323, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_Management_System.Properties.Resources.Acc;
            this.pictureBox1.Location = new System.Drawing.Point(381, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.lnklbl_signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnklbl_changepw);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.LinkLabel lnklbl_changepw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnklbl_signup;
        private System.Windows.Forms.PictureBox pb_login;
        public System.Windows.Forms.TextBox txt_uname;
    }
}