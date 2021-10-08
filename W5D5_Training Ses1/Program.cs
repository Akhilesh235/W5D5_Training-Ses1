using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5D5_Training_Ses1
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelCustomer customers = new HotelCustomer();

            HotelCustomer c1 = new HotelCustomer("akhi", 21);
            HotelCustomer.ad
            
            
            Console.WriteLine("Welcome to Hotel A1");

            bool loop = true;
            List<HotelRooms> RoomsInHotel = new List<HotelRooms>();
            List<HotelCustomer> CustomersInHotel = new List<HotelCustomer>();
            while (loop)
            {
                Console.WriteLine("\nWould you like to book a room ");               
                
                string input = Console.ReadLine();
               
                switch (input.ToUpper())
                {
                    case "YES":
                        {
                            Customerinput:
                            Console.WriteLine("1. Existing Customer");
                            Console.WriteLine("2. New Customer");                            
                            int CustomerInput = int.Parse(Console.ReadLine());                            
                            switch(CustomerInput)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter your name : ");
                                        string OldCustomerName = Console.ReadLine();

                                        var OldCustomer = SearchCustomer(OldCustomerName, CustomersInHotel);
                                        if (OldCustomer == null)
                                        {
                                            Console.WriteLine("non existant");
                                        }

                                        else
                                        {
                                            OldCustomer.getOldCustomerDetails();
                                            Console.WriteLine("\nExisting Customer Details");
                                            Console.WriteLine("Name : " + OldCustomerName);
                                            Console.WriteLine("Age : " + OldCustomer.CustomerAge);

                                        RoomTypeChoice:
                                            Console.WriteLine("What type of room would you like to book?");
                                            Console.WriteLine("1. Normal Room --> $100/night");
                                            Console.WriteLine("2. Deluxe Room --> $200/night");
                                            Console.WriteLine("3. Super Royal Deluxe Suite --> $500/night");

                                            int RoomTypeChoice = int.Parse(Console.ReadLine());
                                            switch (RoomTypeChoice)
                                            {
                                                case 1:
                                                    {
                                                        Console.WriteLine("How many nights would you like to book for?");
                                                        int numofnights = int.Parse(Console.ReadLine());
                                                        int finalcost = numofnights * 100;
                                                        Console.WriteLine("Thank you for booking with us!");
                                                        Console.WriteLine("Your total bill for {0}nights for the Normal Room is ${1}", numofnights, finalcost);

                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        Console.WriteLine("How many nights would you like to book for?");
                                                        int numofnights = int.Parse(Console.ReadLine());
                                                        int finalcost = numofnights * 200;
                                                        Console.WriteLine("Thank you for booking with us!");
                                                        Console.WriteLine("Your total bill for {0}nights for the Deluxe Room is ${1}", numofnights, finalcost);
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        Console.WriteLine("How many nights would you like to book for?");
                                                        int numofnights = int.Parse(Console.ReadLine());
                                                        int finalcost = numofnights * 500;
                                                        Console.WriteLine("Thank you for booking with us!");
                                                        Console.WriteLine("Your total bill for {0}nights for the Super Royal Deluxe Suite is ${1}", numofnights, finalcost);
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        Console.WriteLine("Invalid Input. Try again");
                                                        goto RoomTypeChoice;
                                                    }



                                            }

                                            break;
                                        }

                                        break;
                                    }

                                case 2:
                                    {
                                        Console.WriteLine("\nNew Customer Details ");                                     
                                        Console.WriteLine("Enter your name : ");
                                        string tempCustomerName = Console.ReadLine();
                                        Console.WriteLine("\nEnter your age : ");
                                        int tempCustomerAge = int.Parse(Console.ReadLine());
                                        if(tempCustomerAge >= 21)
                                        {
                                            HotelCustomer hotelCustomer = new HotelCustomer(tempCustomerName, tempCustomerAge);
                                            CustomersInHotel.Add(hotelCustomer);

                                            RoomTypeChoice:
                                            Console.WriteLine("What type of room would you like to book?");
                                            Console.WriteLine("1. Normal Room --> $100/night");
                                            Console.WriteLine("2. Deluxe Room --> $200/night");
                                            Console.WriteLine("3. Super Royal Deluxe Suite --> $500/night");

                                            int RoomTypeChoice = int.Parse(Console.ReadLine());
                                            switch(RoomTypeChoice)
                                            {
                                                case 1:
                                                    {
                                                        Console.WriteLine("How many nights would you like to book for?");
                                                        int numofnights = int.Parse(Console.ReadLine());
                                                        int finalcost = numofnights * 100;
                                                        Console.WriteLine("Thank you for booking with us!");
                                                        Console.WriteLine("Your total bill for {0}nights for the Normal Room is ${1}" , numofnights, finalcost);
                                                        
                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        Console.WriteLine("How many nights would you like to book for?");
                                                        int numofnights = int.Parse(Console.ReadLine());
                                                        int finalcost = numofnights * 200;
                                                        Console.WriteLine("Thank you for booking with us!");
                                                        Console.WriteLine("Your total bill for {0}nights for the Deluxe Room is ${1}", numofnights, finalcost);
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        Console.WriteLine("How many nights would you like to book for?");
                                                        int numofnights = int.Parse(Console.ReadLine());
                                                        int finalcost = numofnights * 500;
                                                        Console.WriteLine("Thank you for booking with us!");
                                                        Console.WriteLine("Your total bill for {0}nights for the Super Royal Deluxe Suite is ${1}", numofnights, finalcost);
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        Console.WriteLine("Invalid Input. Try again");
                                                        goto RoomTypeChoice;
                                                    }

                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You are not qualified to book a room.\nHave a nice day!");
                                            loop = false;
                                            
                                        }
                                        break;
                                    }

                                default:
                                    {
                                        Console.WriteLine("invalid response!");
                                        goto Customerinput;
                                    }

                            }

                            break;
                        }
                    case "NO":
                        {

                            Console.WriteLine("Thank you and have a nice day");
                            loop = false;
                            break;
                        }
               
                    default:
                        Console.WriteLine("Invalid response!");
                        break;
                }
            }

            Console.WriteLine("\nEnter Y to end program : ");
            string str = Console.ReadLine();
            str.ToUpper();
            if (str == "Y")
            {
                loop = false;
            }
        }


        private static HotelCustomer SearchCustomer(string CustomerName, List<HotelCustomer> CustomersInHotel)
        {
            foreach (HotelCustomer hotelcustomer in CustomersInHotel)
            {
                if (hotelcustomer.CustomerName == CustomerName)
                {
                    return hotelcustomer;
                }
            }
            return null;
        }
    }
}
