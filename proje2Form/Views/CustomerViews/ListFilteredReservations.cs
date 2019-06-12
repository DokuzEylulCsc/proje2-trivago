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
    public partial class ListFilteredReservations : Form
    {
        List<Models.Room> rooms;
        Models.User user;
        public ListFilteredReservations(List<Models.Room> rooms, Models.User user)
        {
            InitializeComponent();
            this.rooms = rooms;
        }

        private void ListFilteredReservations_Load(object sender, EventArgs e)
        {
            foreach (Models.Room room in rooms)
            {
                listBox1.Items.Add($"{room.Hotel.Name} Otelinde {room.RoomNumber} Numaralı Oda");
            }
        }
    }
}
