using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{

    public class Room
    {
        private int roomNumber;
        private Customer occupier;
        private bool status;

        public Room(int rnos)
        {
            roomNumber = rnos;
            status = true; // Free
        }

        public void Display()
        {
            Console.WriteLine("Room number: " + roomNumber);
            if (status == true)
            {
                Console.WriteLine("Room is free");
            }
            else
            {
                occupier.Display();
            }
        }

        public void BookRoom(Customer newPerson)
        {
            if (status == true)
            {
                status = false;
                occupier = newPerson;
            }
            else
            {
                Console.WriteLine("Sorry, room booked");
            }
        }

        public void BookRoom()
        {
            Console.WriteLine("Room " + roomNumber);
            if (status == true)
            {
                Customer newPerson = new Customer();
                newPerson.GetName();
                newPerson.GetEmail();
                status = false;
                occupier = newPerson;
            }
            else
            {
                Console.WriteLine("Sorry, room booked");
            }
        }

        public void CancelRoom()
        {
            status = true;
            occupier = null;
            Console.WriteLine("Room cancelled");
        }

        public int returnRoomNumber()
        {
            return (roomNumber);
        }

    }

}
