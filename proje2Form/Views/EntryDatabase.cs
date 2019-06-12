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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Database Files (*.sqlite)|*.sqlite";
            if (openFileDialog.ShowDialog().ToString().Equals("OK"))
            {
                Logger.DatabaseLoaded(openFileDialog.FileName);
                Database.sqlConnection = new SQLiteConnection("Data Source=" + openFileDialog.FileName + ";Version=3;");
                Database.sqlConnection.Open();
                Views.Login login = new Views.Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seçilen dosya geçersiz programı tekrar başlatın");
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Sonraki Diyalogda Veritabanı Dosyasının Nereye Kaydedileceğini Seçiniz");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Database Files (*.sqlite)|*.sqlite";
            saveFileDialog.ShowDialog();
            System.IO.File.Copy(System.Reflection.Assembly.GetEntryAssembly().Location + @"\..\..\..\taslak.sqlite", saveFileDialog.FileName);
            Database.sqlConnection = new SQLiteConnection("Data Source=" + saveFileDialog.FileName + ";Version=3;");
            Database.sqlConnection.Open();
            Logger.DatabaseCreated(saveFileDialog.FileName);
            Views.Login login = new Views.Login();
            login.Show();
            this.Hide();
        }
    }
}
