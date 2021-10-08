using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5D5_Training_Ses1
{
    class HotelCustomer
    {
        public string CustomerName { get; set; }
        public int CustomerAge { get; set; }

        public List<HotelRooms> previousRoom
        {
            get;
            set;
        }

        public HotelCustomer(string customerName, int customerAge)
        {
            CustomerName = customerName;
            CustomerAge = customerAge;
            previousRoom = new List<HotelRooms>();
        }

        public void getOldCustomerDetails()
        {
            Console.WriteLine("Customer Name : " + CustomerName);
            Console.WriteLine("Customer Age : " + CustomerAge);
            Console.WriteLine("Previous Room Stayed : " + previousRoom);
        }



        
        
    }
}
