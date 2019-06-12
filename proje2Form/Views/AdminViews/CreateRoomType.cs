using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2Form.Views.AdminViews
{
    public partial class CreateRoomType : Form
    {
        public CreateRoomType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controllers.RoomController.CreateRoomType(textBox1.Text);
            this.Close();
        }
    }
}
