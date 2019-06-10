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
    public partial class EntryDatabase : Form
    {
        public EntryDatabase()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sQLiteConnection;
            MessageBox.Show("Lütfen Sonraki Diyalogda Kullanmak İstediğiniz Veritabanı dosyasını seçiniz!!");
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog().Equals("OK"))
            {
                sQLiteConnection = new SQLiteConnection("Data Source=" + openFileDialog1.FileName + ";Version=3;");
            }
            else
            {

            }
            Main_Menu main_Menu = new Main_Menu(this);
            main_Menu.Show();
        }
    }
}
