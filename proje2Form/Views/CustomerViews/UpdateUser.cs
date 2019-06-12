using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2Form.Views.CustomerViews
{
    public partial class UpdateUser : Form
    {
        Models.User user;
        public UpdateUser(Models.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            label1.Text = $"{user.Name} {user.Name} Hoşgeldiniz, ID'niz: {user.Id}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controllers.UserController.UserUpdate(user.Id, textBox1.Text, textBox2.Text);
        }
    }
}
