using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGame
{
    class Room
    {
        int blockSize;
        int stayingPrice;
        int buildCost;
        int beds;

        public Room(int BlockSize, int StayingPrice, int BuildCost, int Beds)
        {
            blockSize = BlockSize;
            stayingPrice = StayingPrice;
            beds = Beds;
            buildCost = BuildCost;
        }
    }
}
