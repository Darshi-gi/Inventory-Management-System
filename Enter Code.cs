using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Inventory_Management_System
{
    public partial class Enter_Code : Form
    {
        string randomCode;
        public static string to;
        public Enter_Code()
        {
            InitializeComponent();
        }

        

        private void btn_sendcode_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txt_enteremail.Text).ToString();
            from = "puchustalks@gmail.com";
            pass = "codse022@puchus";
            messagebody = "Your password reset code is" + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (randomCode == (txt_entercode.Text).ToString())
            {
                to = txt_enteremail.Text;
                New_Password cp = new New_Password();
                this.Hide();
                cp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void Enter_Code_Load(object sender, EventArgs e)
        {

        }
    }
}
