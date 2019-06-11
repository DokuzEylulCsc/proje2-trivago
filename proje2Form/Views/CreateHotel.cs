﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace proje2Form.Views
{
    public partial class CreateHotel : Form
    {
        public CreateHotel()
        {
            InitializeComponent();
        }

        private void CreateHotel_Load(object sender, EventArgs e)
        {
            Database.sqlCommand.CommandText = "Select * from hotel_types";
            Database.sqlCommand.Connection = Database.sqlConnection;
            Database.sqlDataReader = Database.sqlCommand.ExecuteReader();
            while (Database.sqlDataReader.Read())
            {
                comboBox1.Items.Add(Database.sqlDataReader["hotel_type_name"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Controllers.HotelController.CreateHotel(comboBox1.SelectedItem.ToString(), textBox1.Text, Convert.ToInt32(comboBox2.SelectedItem));
                MessageBox.Show("İşlem Tamam");
                this.Close();
            }
            catch(NullReferenceException nre)
            {
                Exceptions.ExceptionLogger.LogAnExcaption(nre);
                MessageBox.Show("Lütfen gerekli seçimleri yaptığınızdan emin olunuz!");
            }
        }
    }
}
