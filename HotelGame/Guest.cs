using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGame
{
    public class Guest
    {
        // Genaral Info
        private string name;
        private int amtPeople;
        private int hoursLeft;

        // From a scale from 1 - 5, what do they think of their stay?
        //int happy;
        //int confort; 

        // Race? Curse? Dimention? Planet?

        string[] surnames = { "Jacob", "Samuel", "Max", "Linn", "Felicia", "Caroline" };
        string[] lastnames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller" };

        Random r = new Random();

        public Guest(int AmountPeople, int StayDays)
        {
            string fore = surnames[r.Next(surnames.Length)];
            string sur = lastnames[r.Next(lastnames.Length)];
            name = fore + " " + sur;
            amtPeople = AmountPeople;
            hoursLeft = StayDays;
        }

        public string getName()
        {
            return name;
        }

        public bool isLeaving()
        {
            return hoursLeft <= 0;
        }

        public void hourHasPassed()
        {
            hoursLeft--;
        }

        public int getHoursLeft()
        {
            return hoursLeft;
        }

        public int getAmountOfPeople()
        {
            return amtPeople;
        }

    }
}
