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
    public partial class Manage_Suppliers : Form
    {
        public Manage_Suppliers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DC5IJ0BJ\\SQLEXPRESS;Initial Catalog=Inventory Management;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        private void Manage_Suppliers_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-DC5IJ0BJ\\SQLEXPRESS;Initial Catalog=Inventory Management;Integrated Security=True");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_sid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_sname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dataGridView1.Rows[0].Cells[2].Value = date.Value.ToString();
            txt_address.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_country.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_contact.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txt_email.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void pb_home_Click(object sender, EventArgs e)
        {
            Welcome_Home wh = new Welcome_Home();
            this.Hide();
            wh.Show();
        }

        private void btn_addsupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_sid.Text) || txt_sid.Text.Any(char.IsLetter))
                    MessageBox.Show("Supplier ID cannot be blank and cannot enter Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_sname.Text) || txt_sname.Text.Any(char.IsDigit))
                    MessageBox.Show("Supplier Name cannot be blank and cannot enter Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_address.Text))
                    MessageBox.Show("Address cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_country.Text) || txt_country.Text.Any(char.IsDigit))
                    MessageBox.Show("Country name cannot be blank and cannot enter Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_contact.Text) || txt_contact.Text.Any(char.IsLetter))
                    MessageBox.Show("Contact cannot be blank and cannot enter Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_email.Text))
                    MessageBox.Show("Email cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    con.Open();
                    string query = "INSERT INTO Manage_Suppliers (Supplier_ID, Supplier_Name, Date, Address, Country, Contact, Email) VALUES ('" + txt_sid.Text + "', '" + txt_sname.Text + "','" + date.Value.ToString() + "','" + txt_address.Text + "','" + txt_country.Text + "','" + txt_contact.Text + "','" + txt_email.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Supplier Added Successfully");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_disp_Click(object sender, EventArgs e)
        {   try
            {
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM Manage_Suppliers", con);
                DataTable dt = new DataTable();
                sda.Fill(dt); dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Manage_Suppliers WHERE Supplier_ID = '"+txt_sid.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Supplier Delete Successfully");
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Manage_Suppliers SET Supplier_Name = '" + txt_sname.Text + "' ,  Date = '" + date.Value.ToString() + "' , Address = '"+txt_address.Text+"' , Country = '"+txt_country.Text+"' , Contact = '"+txt_contact.Text+"' , Email = '"+txt_email.Text+"' WHERE Supplier_ID = '" +txt_sid.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
