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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Start();
        }

        Random r = new Random();

        int money;
        int guests;
        int rooms;
        int roomCap;
        int roomCost;
        int roomsDirty;
        int roomExpandCost;
        int roomBuildTime;
        int roomExpandTime;
        int roomStayingPrice;

        double publicity;

        string hotelName;

        bool tuturial = true;

        public void Start()
        {
            hotelName = "This hotel";
            money = 300;
            guests = 0;

            rooms = 0;
            roomCap = 5;
            roomsDirty = 0;
            roomCost = 200;
            roomExpandCost = 550;
            roomBuildTime = 5;
            roomExpandTime = 30;
            roomStayingPrice = 150;

            publicity = 0.01;

            tbcHotel.TabPages.Remove(tabWork);
            tbcHotel.TabPages.Remove(tabResturant);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        int updateCount = 0;
        int waitCount = 0;
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            // Update counters
            updateCount++;
            if (waitCount > 0) waitCount--;

            // Update Labels
            tbxHotelInfo.Text = "Hotel Name: " + hotelName + "\n\nMoney: " + money + " $\nIncome: " + roomStayingPrice + " $\nTot. Rooms: " + rooms + "\nAvbl. Rooms: " + (rooms - roomsDirty);

            // Update Buttons
            if (roomCost > money)
            {
                btnNewRoom.Enabled = false;
            }
            else
            {
                btnNewRoom.Enabled = true;
            }

            // Events
            if (updateCount == 100)
            {
                Output("Hum. Without any rooms you won't get any guests... Better start buildning one!");
                btnNewRoom.Visible = true;
            }

            // Update Tabs

            // Check for arriving Guests
            if (updateCount % 300 == 0 && waitCount == 0)
            {
                if (guests < (rooms - roomsDirty))
                {
                    guests++;

                    if (tuturial)
                    {
                        Output("Oh, theres your first guest! It seems like they will simply show up if you have free rooms. Now, let's wait till he leaves.\n( +1 Guest )");
                    }
                    else
                    {
                        switch (r.Next(0, 3))
                        {
                            case 0:
                                Output("A new guest just arrived. Welcome! \n( +1 guest )");
                                break;
                            case 1:
                                Output("Welcome to " + hotelName + ", please enjoy your stay! \n( +1 guest )");
                                break;
                            case 2:
                                Output("Yes? How may I help you? \n( +1 guest )");
                                break;
                        }
                    }
                }
            }

            // Check for leaving Guests
            if (updateCount % 300 == 0 && waitCount == 0)
            {
                if (guests > 0)
                {
                    guests--;
                    roomsDirty++;
                    btnCleanRoom.Text = "Clean a room - 10 $ - " + roomsDirty + " left";

                    if (tuturial)
                    {
                        Output("Your first guest is leaving and paying for his stay. 'My first income!' you think while you excitingly recive the money. The guest looks at you a bit guily and before leaving he tells you the toilet is clogged." + 
                            " Right. You had almost forgotten you have to clean the rooms after the guests. 'Sigh. The sooner it's done, the better.'");
                        btnCleanRoom.Visible = true;
                    }
                    else
                    {
                        switch (r.Next(0, 5))
                        {
                            case 0:
                                Output("Thanks for your visit!\n(-1 guest, +" + roomStayingPrice + " $)");
                                break;
                            case 1:
                                Output("It was a pleasure having you here at " + hotelName + ". \n(-1 guest, +" + roomStayingPrice + " $)");
                                break;
                            case 2:
                                Output("Please, come again!\n(-1 guest, +" + roomStayingPrice + " $)");
                                break;
                            case 3:
                                Output("Untill next time!\n(-1 guest, +" + roomStayingPrice + " $)");
                                break;
                            case 4:
                                Output("I hope you had a good stay.\n(-1 guest, +" + roomStayingPrice + " $)");
                                break;
                        }
                    }
                    
                    money += roomStayingPrice;
                }
            }
        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            if (roomCost <= money)
            {
                // Pay
                money -= roomCost;

                // Wait for construction
                pgbRoom.Visible = true;
                tmrRoomBuild.Enabled = true;
                btnNewRoom.Enabled = false;
            }
        }

        private void Output(string text)
        {
            string oldText = tbxInfo.Text;
            tbxInfo.Text = text;
            tbxInfo.AppendText("\n \n" + oldText);
            waitCount = 100;
        }

        private void NewRoom()
        {
            rooms++;

            if (tuturial)
            {
                Output("You just bought your first hotel, but now you have a proper room as well! This is going good! Now you just have to wait for your first guest.\n( -" + roomCost + " $, +1 Room )");
            }
            else
            {
                switch (r.Next(0, 3))
                {
                    case 0:
                        Output("Auch! Building a new room was more expensive than you thought it would be.\n( -" + roomCost + " $, +1 Room )");
                        break;
                    case 1:
                        Output("Room construction done. What a relief!\n(-" + roomCost + " $, +1 Room)");
                        break;
                    case 2:
                        Output("Those builders sure took their time! Should ask for compensation?\n( -" + roomCost + " $, +1 Room )");
                        break;
                }
            }
            
            gbxRooms.Text = "Rooms (" + rooms + "/" + roomCap + ")";
            double newCost = roomCost * 1.15;
            roomCost = (int)newCost;
            roomBuildTime += 5;
            btnNewRoom.Text = "Build new Room  -  " + roomCost + " $";
        }

        int count = 0;

        private void tmrBuild_Tick(object sender, EventArgs e)
        {
            count++;
            pgbRoom.Value = count / roomBuildTime;

            if (pgbRoom.Value >= 100)
            {
                NewRoom();
                if (rooms != roomCap)
                {
                    btnNewRoom.Enabled = true;
                }
                tmrRoomBuild.Enabled = false;
                pgbRoom.Visible = false;
                count = 0;
            }
        }

        private void btnCleanRoom_Click(object sender, EventArgs e)
        {
            roomsDirty--;

            switch (r.Next(0, 3))
            {
                default:
                    Output("The room is now clean.\n( -1 Dirty Room )");
                    break;
            }

            if (roomsDirty == 0)
            {
                btnCleanRoom.Enabled = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
