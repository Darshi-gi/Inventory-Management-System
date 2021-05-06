using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Inventory_Management_System
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

        }
        SqlConnection con;
        SqlCommand cmd;
        private void pb_back_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-DC5IJ0BJ\\SQLEXPRESS;Initial Catalog=Inventory Management;Integrated Security=True");
        }

        private void pb_signup_Click(object sender, EventArgs e)
        { try
            {
                if (String.IsNullOrEmpty(txt_nic.Text) || txt_nic.Text.Any(char.IsPunctuation))
                    MessageBox.Show("NIC cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_fname.Text) || txt_fname.Text.Any(char.IsDigit))
                    MessageBox.Show("First Name cannot be blank and cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_lname.Text) || txt_lname.Text.Any(char.IsDigit))
                    MessageBox.Show("Last Name cannot be blank and cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_contact.Text) || txt_contact.Text.Any(char.IsLetter))
                    MessageBox.Show("Contact cannot be blank and Contact Must have 10 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_email.Text))
                    MessageBox.Show("Email cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_address.Text))
                    MessageBox.Show("Address Cannot Be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_uname.Text))
                    MessageBox.Show("User Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_password.Text))
                    MessageBox.Show("Password Cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (txt_password.Text != txt_cpassword.Text)
                    MessageBox.Show("Password does not match");

                else
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Signup(NIC,First_Name,Last_Name,Contact,Date_Of_Birth,Email,Address,User_Name,Password) VALUES('" + txt_nic.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_contact.Text + "','" + DOB.Value.ToString() + "','" + txt_email.Text + "','" + txt_address.Text + "','" + txt_uname.Text + "','" + txt_password.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Signup Successfully!!!");
                    new Login().Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
            }
        }
      }
}


