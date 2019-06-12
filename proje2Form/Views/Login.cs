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
            if (Convert.ToInt32(textBox1.Text) == 1)
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
            }
            else
            {
                //Database.GetUserByID(Convert.ToInt32(textBox1.Text)) eklenecek
            }
        }
    }
}
