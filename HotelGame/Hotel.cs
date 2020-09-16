using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelGame
{
    enum HotelState { Tutorial, Stage1 }

    class Hotel
    {
        private HotelState state = HotelState.Tutorial;

        // Rooms you can potentially build
        private Room Room = new Room(1, 150, 200, 1);
        private Room Double = new Room(2, 200, 500, 2);
        private Room Family = new Room(5, 240, 1000, 4);

        Action<string[], string> print;
        Action<Hotel> update;

        public static string name { get; private set; } = "This hotel";
        public int money { get; private set; } = 315;
        public int rooms { get; private set; } = 0;
        public int roomCap { get; private set; } = 5;
        public int roomsDirty { get; private set; } = 0;
        public int roomsCleaned { get; private set; } = 0;
        public int roomCost { get; private set; } = 200;
        public int roomExpandCost { get; private set; } = 550;
        public int roomBuildTime { get; private set; } = 100;
        public int roomCleanTime { get; private set; } = 80;
        public int roomStayingPrice { get; private set; } = 150;
        public int roomCleanCost { get; private set; } = 25;

        public List<Guest> guests { get; private set; } = new List<Guest>();
        public int guestMaxStayTime { get; private set; } = 4;
        public int guestMinStayTime { get; private set; } = 4;



        public Hotel(Action<string[], string> outputFunc, Action<Hotel> updateLabelFunc)
        {
            print = outputFunc;
            update = updateLabelFunc;
            update(this);
        }

        public void buildNewRoom()
        {
            rooms++;
            roomCost = (int)(roomCost * 1.15);
            roomBuildTime = (int)(roomBuildTime * 1.15);

            string[] buildStrs = isTutorial() ? Dialog.buildRoomTut : Dialog.buildRoom;
            print(buildStrs, ("-" + roomCost + " $, +1 Room") );

            update(this);
        }

        public bool isTutorial()
        {
            return state == HotelState.Tutorial;
        }

        public void onHourPassed()
        {
            // Update guests
            for (int i = 0; i < guests.Count; i++)
            {
                var guest = guests[i];
                guest.hourHasPassed();
                if (guest.isLeaving())
                {
                    guestLeft(guest);
                    i--;
                }
            }
        }

        public void guestLeft(Guest guest)
        {
            guests.Remove(guest);
            //soundCash.Play();
            roomsDirty++;
            money += roomStayingPrice;
            update(this);

            string[] leftStrs = isTutorial() ? Dialog.guestLeftTut : Dialog.guestLeft;
            print(leftStrs, "-1 guest, +" + roomStayingPrice + " $");
        }

        internal void guestArrived()
        {
            Random rand = new Random();
            Guest newGuest = new Guest(1, rand.Next(1, rand.Next(guestMinStayTime, guestMaxStayTime)));
            guests.Add(newGuest);
            //soundGuestArriving.Play();

            string[] strs = isTutorial() ? Dialog.guestArrivedTut : Dialog.guestArrived;
            print(strs, "+1 guest");
        }

        public void spendMoney(int m)
        {
            money -= m;
        }

        internal void cleanRoom()
        {
            roomsDirty--;
            roomsCleaned++;
            update(this);

            string[] strs = isTutorial() ? Dialog.cleanRoomTut : Dialog.cleanRoom;
            print(strs, "( -1 Dirty Room )");

            if (isTutorial())
            {
                print(new string[1] { "TUTORIAL OVER! GOOD LUCK!" }, "");
                state = HotelState.Stage1;
            }
        }
    }
}
