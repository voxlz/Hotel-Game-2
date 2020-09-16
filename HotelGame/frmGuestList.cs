using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGame
{
    public partial class frmGuestList : Form
    {
        List<Guest> guestList;

        public frmGuestList(List<Guest> GuestList)
        {
            guestList = GuestList;
            InitializeComponent();
            DisplayData();
        }

        public void DisplayData()
        {
            //lvwGuests.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvwGuests.Items.Clear();

            for (int i = 0; i < guestList.Count; i++)
            {
                string[] row = { guestList[i].getHoursLeft().ToString(), guestList[i].getAmountOfPeople().ToString() };
                lvwGuests.Items.Add(guestList[i].getName()).SubItems.AddRange(row);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
