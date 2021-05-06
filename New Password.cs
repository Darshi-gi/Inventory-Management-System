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
    public partial class New_Password : Form
    {
        string User_Name = Enter_Code.to;
        public New_Password()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void pb_back_Click(object sender, EventArgs e)
        {
            Enter_Code ec = new Enter_Code();
            this.Hide();
            ec.Show(); 
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_newpw.Text == txt_confirmnewpw.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-DC5IJ0BJ\\SQLEXPRESS;Initial Catalog=Inventory Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Signup SET Password = '" + txt_newpw.Text + "' WHERE User_Name = '" + txt_confirmnewpw.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Reset Successfully");
                Login lg = new Login();
                this.Hide();
                lg.Show();
            }
            else
            {
                MessageBox.Show("The Password does not match");
            }
        }

        private void txt_newpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_confirmnewpw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
