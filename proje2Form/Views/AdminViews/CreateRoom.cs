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
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            List<Models.Hotel> hotels = Controllers.HotelController.ListHotels();
            foreach (Models.Hotel hotel in hotels)
            {
                comboBox1.Items.Add(hotel.Name);
            }

            List<string> rooms = Controllers.RoomController.GetRoomTypes();
            foreach (string room in rooms)
            {
                comboBox2.Items.Add(room);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Hotel selectedHotel = new Models.Hotel();
                List<Models.Hotel> hotels = Controllers.HotelController.ListHotels();
                foreach (Models.Hotel hotel in hotels)
                {
                    if (comboBox1.SelectedItem.ToString() == hotel.Name) selectedHotel = hotel;
                }
                Controllers.RoomController.CreateRoom(comboBox2.SelectedItem.ToString(), Convert.ToDouble(textBox2.Text), selectedHotel);
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
