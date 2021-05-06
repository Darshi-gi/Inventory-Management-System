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
    public partial class Manage_Stock : Form
    {
        public Manage_Stock()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DC5IJ0BJ\\SQLEXPRESS;Initial Catalog=Inventory Management;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {   
            txt_portno.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_iname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_quantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_oprice.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txt_increased.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cmb_measure.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            cmb_supplier.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txt_cprice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dataGridView1.Rows[0].Cells[1].Value = date.Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manage_Stock_Load(object sender, EventArgs e)
        {

        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_portno.Text))
                    MessageBox.Show("Port No cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_iname.Text) || txt_iname.Text.Any(char.IsDigit))
                    MessageBox.Show("Item Name cannot be blank and cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_quantity.Text) || txt_quantity.Text.Any(char.IsLetter))
                    MessageBox.Show("Quantity cannot be blank and cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_cprice.Text) || txt_cprice.Text.Any(char.IsLetter))
                    MessageBox.Show("Current Price cannot be blank and cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_oprice.Text) || txt_oprice.Text.Any(char.IsLetter))
                    MessageBox.Show("Original price cannot be blank and cannot have Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_increased.Text) || txt_increased.Text.Any(char.IsLetter))
                    MessageBox.Show("Increased cannot be blank and Cannot have Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(cmb_measure.Text))
                    MessageBox.Show("Select Measure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(cmb_supplier.Text))
                    MessageBox.Show("Select Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    con.Open();
                    string query = "INSERT INTO Manage_Stock (Date , Port_No , Item_Name , Quantity , Current_Price , Original_Price , Increased_By , Measurement , Supplier) VALUES ('" + date.Value.ToString() + "' , '" + txt_portno.Text + "' ,  '" + txt_iname.Text + "','" + txt_quantity.Text + "','" + txt_cprice.Text + "','" + txt_oprice.Text + "','" + txt_increased.Text + "' ,'" + cmb_measure.Text + "' ,'" + cmb_supplier.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item Added Successfully");
                }
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                sda = new SqlDataAdapter("SELECT * FROM Manage_Stock", con);
                DataTable dt = new DataTable();
                sda.Fill(dt); dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Manage_Stock SET Date = '" + date.Value.ToString() + "' , Item_Name = '"+txt_iname.Text+"' , Quantity = '"+txt_quantity.Text+"' , Current_Price = '"+txt_cprice.Text+"' , Original_Price = '"+txt_oprice.Text+"' , Increased_By = '"+txt_increased.Text+"' , Measurement = '"+cmb_measure.Text+"' , Supplier = '"+cmb_supplier.Text+"'  WHERE Port_No = '" + txt_portno.Text + "'");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Manage_Stock WHERE Port_No = '" + txt_portno.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Item Delete Successfully");
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
