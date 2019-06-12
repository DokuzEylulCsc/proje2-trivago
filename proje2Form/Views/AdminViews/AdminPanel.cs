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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateHotel createHotel = new CreateHotel();
            createHotel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateRoom createRoom = new CreateRoom();
            createRoom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateHotelType createHotelType = new CreateHotelType();
            createHotelType.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetReservations getReservations = new GetReservations();
            getReservations.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListHotels list = new ListHotels();
            list.Show();
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.ProgramStopped();
            Application.Exit();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AdminViews.CreateRoomType createRoomType = new AdminViews.CreateRoomType();
            createRoomType.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminViews.CreateRoomProp createRoomProp = new AdminViews.CreateRoomProp();
            createRoomProp.Show();
        }
    }
}
