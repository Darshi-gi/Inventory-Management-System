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
    public partial class pos : Form
    {
        public pos()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataAdapter sda;

        SqlConnection con = new SqlConnection(@"Data Source=DARSHI;Initial Catalog=POS;Integrated Security=True ");



        private void pb_home_Click(object sender, EventArgs e)
        {
            Welcome_Home wh = new Welcome_Home();
            this.Hide();
            wh.Show();
        }

        private void POS(object sender, EventArgs e)
        {

        }

        private void btn_addcart_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(cmb_portno.Text))
                {
                    MessageBox.Show("Port No cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else if (String.IsNullOrEmpty(txt_quantity.Text) || txt_quantity.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Quantity cannot be blank and cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrEmpty(txt_cprice.Text) || txt_cprice.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Current Price cannot be blank and cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrEmpty(txt_cprice.Text) || txt_cprice.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Current Price cannot be blank and cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (String.IsNullOrEmpty(txt_supplier.Text))
                {
                    MessageBox.Show("supplier cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Checkout_pos(PO_no,Date,Qunty,Cu_Price,supplier_Name,Qunty_Req,F_price)VALUES('" + cmb_portno.Text + "','" + dateTimePicker1.Text + "','" + txt_cprice.Text + "','" + txt_cprice.Text + "','" + txt_supplier.Text + "','" + txt_quantityreq.Text + "','" + txt_fprice.Text + "','" + txt_totsale.Text + "')");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("INSERTED SUCCESSFULLY !!");
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Purchase_Order_Invoice_Load(object sender, EventArgs e)
        {


        }
    }
}

            