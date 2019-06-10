using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2Form
{
    public partial class Main_Menu : Form
    {
        Form father;
        public Main_Menu(Form father)
        {
            InitializeComponent();
            this.father = father;
            father.Hide();
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            father.Close();
        }
    }
}
