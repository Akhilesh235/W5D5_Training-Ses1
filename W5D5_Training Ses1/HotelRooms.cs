using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5D5_Training_Ses1
{
    class HotelRooms
    {
        public string TypeOfRoom { get; set; }
        public int NumofRooms { get; set; }

        public void getRoomDetails()
        {
            Console.WriteLine("Type of Room : " + TypeOfRoom);
            Console.WriteLine("Number of Rooms Available : " + NumofRooms);
        }
    }
}
