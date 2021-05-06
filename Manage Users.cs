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
    public partial class Manage_Users : Form
    {
        public Manage_Users()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DC5IJ0BJ\\SQLEXPRESS;Initial Catalog=Inventory Management;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        private void btn_adduser_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            this.Hide();
            su.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-DC5IJ0BJ\\SQLEXPRESS;Initial Catalog=Inventory Management;Integrated Security=True");   
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_nic.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_fname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_lname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_contact.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dataGridView1.Rows[0].Cells[4].Value = dob.Value.ToString();
            txt_email.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txt_address.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txt_email.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txt_uname.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            try
                {
                con.Open();
                cmd = new SqlCommand ("UPDATE Signup SET First_Name = '" + txt_fname.Text + "' , Last_Name = '" + txt_lname.Text + "' , Contact = '"+txt_contact.Text+"' , Date_Of_Birth = '" + dob.Value.ToString() + "' , Email = '" + txt_email.Text + "' , Address = '" + txt_address.Text + "' , User_Name = '" + txt_uname.Text + "' ,  WHERE NIC = '" + txt_nic.Text + "'");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_del_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Signup WHERE NIC = '" + txt_nic.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Delete Successfully");
        }

        private void pb_home_Click(object sender, EventArgs e)
        {
            Welcome_Home wh = new Welcome_Home();
            this.Hide();
            wh.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM Signup", con);
                DataTable dt = new DataTable();
                sda.Fill(dt); dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
