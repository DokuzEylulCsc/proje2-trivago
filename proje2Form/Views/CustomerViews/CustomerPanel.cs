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
    public partial class CustomerPanel : Form
    {
        Models.User user; 
        public CustomerPanel(Models.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {

        }

        private void CustomerPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.ProgramStopped();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerViews.UpdateUser updateUser = new CustomerViews.UpdateUser(user);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerViews.SearchReservation searchReservation = new CustomerViews.SearchReservation(user);
            searchReservation.Show();
        }
    }
}
