﻿using System;
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
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            foreach (Models.Hotel hotel in Controllers.HotelController.hotels)
            {
                comboBox1.Items.Add(hotel.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Controllers.RoomController.CreateRoom()
                MessageBox.Show("İşlem Tamam");
                this.Close();
            }
            catch (NullReferenceException nre)
            {
                Exceptions.ExceptionLogger.LogAnExcaption(nre);
                MessageBox.Show("Lütfen gerekli seçimleri yaptığınızdan emin olunuz!");
            }
        }
    }
}