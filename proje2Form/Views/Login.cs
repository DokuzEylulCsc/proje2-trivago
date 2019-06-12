using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2Form.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.User user = Controllers.UserController.GetUserById(Convert.ToInt32(textBox1.Text));
            if (user.IsAdmin == true)
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
            }
            else
            {
                CustomerPanel customerPanel = new CustomerPanel();
                customerPanel.Show();
            }
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
