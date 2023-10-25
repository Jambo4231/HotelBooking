using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{

    public class Floor
    {
        public int floorNumber;
        private Room[] rooms = new Room[4];

        public Floor(int nos)
        {
            floorNumber = nos;
            rooms[0] = new Room(1);
            rooms[1] = new Room(2);
            rooms[2] = new Room(3);
            rooms[3] = new Room(4);
        }

        public void DisplayFloor()
        {
            Console.WriteLine("Floor: " + floorNumber);

            for (int counter = 0; counter < rooms.Length; counter++)
            {
                rooms[counter].Display();
            }
        }

        public void FindRoomToBook()
        {
            Console.Write("Please enter room number: ");
            int nos = int.Parse(Console.ReadLine());
            bool found = false;

            foreach (Room room in rooms)
            {
                if (room.returnRoomNumber() == nos)
                {
                    found = true;
                    room.BookRoom();
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("No such room number.");
            }
        }

        public void FindRoomToCancel()
        {
            Console.Write("Please enter room number: ");
            int nos = int.Parse(Console.ReadLine());
            bool found = false;

            foreach (Room room in rooms)
            {
                if (room.returnRoomNumber() == nos)
                {
                    found = true;
                    room.CancelRoom();
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("No such room number.");
            }
        }
    }
}
