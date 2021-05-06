using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DC5IJ0BJ\\SQLEXPRESS;Initial Catalog=Inventory Management;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void lnklbl_signup_MouseEnter(object sender, EventArgs e)
        {
            lnklbl_changepw.ForeColor = Color.White;
        }

        private void lnklbl_signup_MouseLeave(object sender, EventArgs e)
        {
            lnklbl_changepw.ForeColor = Color.Blue;
        }

        private void lnklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void lnklbl_changepw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Enter_Code ec = new Enter_Code();
            this.Hide();
            ec.Show();
        }

        private void pb_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-DC5IJ0BJ\\SQLEXPRESS;Initial Catalog=Inventory Management;Integrated Security=True");
            string query = "Select * from signup Where user_name = '"+txt_uname.Text.Trim()+"'  and password = '" +txt_password.Text.Trim()+"'" ;
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable signup = new DataTable();
            sda.Fill(signup);
            if (signup.Rows.Count == 1)
            {
                Welcome_Home objWelcome = new Welcome_Home();
                this.Hide();
                Welcome_Home cs = new Welcome_Home();
                cs.Show();
            }
            else
            {
                MessageBox.Show("Check your user name and Password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
