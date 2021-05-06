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
    public partial class Purchase_Orders : Form
    {
        public Purchase_Orders()
        {
            InitializeComponent();
        }

        private void pb_purordinv_Click(object sender, EventArgs e)
        {
            Purchase_Order_Invoice poi = new Purchase_Order_Invoice();
            this.Hide();
            poi.Show();
        }
    }
}
