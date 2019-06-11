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
    public partial class ListHotels : Form
    {
        public ListHotels()
        {
            InitializeComponent();
        }

        private void ListHotels_Load(object sender, EventArgs e)
        {
            List<Models.Hotel> hotels = Database.ListHotels();
            foreach (Models.Hotel hotel in hotels)
            {
                listBox1.Items.Add(hotel.Name);
            }
        }
    }
}
