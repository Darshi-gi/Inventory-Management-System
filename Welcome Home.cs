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
    public partial class Welcome_Home : Form
    {
        public Welcome_Home()
        {
            InitializeComponent();
        }

        private void pb_musers_Click(object sender, EventArgs e)
        {
            Manage_Users mu = new Manage_Users();
            this.Hide();
            mu.Show();
        }

        private void pb_logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void pb_msuppliers_Click(object sender, EventArgs e)
        {
            Manage_Suppliers wh = new Manage_Suppliers();
            this.Hide();
            wh.Show();
        }

        private void pb_mproducts_Click(object sender, EventArgs e)
        {
            Manage_Stock ms = new Manage_Stock();
            this.Hide();
            ms.Show();
        }

        private void pb_poders_Click(object sender, EventArgs e)
        {
            Purchase_Orders po = new Purchase_Orders();
            this.Hide();
            po.Show();
        }

        private void pb_pos_Click(object sender, EventArgs e)
        {
            pos pos = new pos();
            this.Hide();
            pos.Show();
        }

        private void pb_rteturns_Click(object sender, EventArgs e)
        {
            Returns rn = new Returns();
            this.Hide();
            rn.Show();
        }
    }
}
