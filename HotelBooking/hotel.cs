using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{
    using System;

    public class Hotel
    {
        private int hotelNumber;
        private string hotelName;
        public Floor[] floors = new Floor[4];

        public Hotel(int nos, string name)
        {
            hotelNumber = nos;
            hotelName = name;
            floors[0] = new Floor(1);
            floors[1] = new Floor(2);
            floors[2] = new Floor(3);
            floors[3] = new Floor(4);
        }

        public void Display()
        {
            Console.WriteLine("Hotel Name: " + hotelName);
            for (int counter = 0; counter < floors.Length; counter++)
            {
                floors[counter].DisplayFloor();
            }
        }

        public void Display(int floornos)
        {
            Console.WriteLine("Hotel Name: " + hotelName);
            floors[floornos - 1].DisplayFloor();
        }

        public void BookARoom()
        {
            Console.Write("Which floor would you like to stay on? ");
            int floorChoice = int.Parse(Console.ReadLine());
            floors[floorChoice - 1].FindRoomToBook();
        }

        public void CancelARoom()
        {
            Console.Write("Which floor are you staying on? ");
            int floorChoice = int.Parse(Console.ReadLine());
            floors[floorChoice - 1].FindRoomToCancel();
        }
    }

}
