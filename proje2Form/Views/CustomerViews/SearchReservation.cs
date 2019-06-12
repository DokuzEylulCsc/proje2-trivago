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
    public partial class SearchReservation : Form
    {
        Models.User user;
        public SearchReservation(Models.User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void MakeReservation_Load(object sender, EventArgs e)
        {
            List<string> roomProps = Controllers.RoomController.GetRoomProps();
            foreach (string prop in roomProps)
            {
                listBox1.Items.Add(prop);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inDate = dateTimePicker1.Value;
            DateTime outDate = dateTimePicker2.Value;
            List<string> props = new List<string>();
            foreach (int i in listBox1.SelectedIndices)
            {
                props.Add(listBox1.Items[i].ToString());
            }
            List<Models.Room> rooms = Controllers.ReservationController.SearchReservation(props, inDate, outDate);
            ListFilteredReservations fr = new ListFilteredReservations(rooms, user);
        }
    }
}
