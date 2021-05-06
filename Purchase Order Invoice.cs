using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Purchase_Order_Invoice : Form
    {
        public Purchase_Order_Invoice()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Welcome_Home wh = new Welcome_Home();
            this.Hide();
            wh.Show();
        }
    }
}
