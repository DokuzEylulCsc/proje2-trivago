using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace proje2Form
{
    public partial class Main_Menu : Form
    {
        SQLiteConnection sQLiteConnection;
        public Main_Menu()
        {
            InitializeComponent();
        }

        public Main_Menu(SQLiteConnection sQLiteConnection)
        {
            InitializeComponent();
            this.sQLiteConnection = sQLiteConnection;
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
