using HotelBooking;
using System;


public class RoomMenu
{
    public static void Main(string[] args)
    {
        // Initialize your hotel and floors
        Hotel hotel = new Hotel(101, "The Grand");
        Floor selectedFloor = null;

        while (true)
        {
            Console.WriteLine("Room Management Menu:");
            Console.WriteLine("1. Display Hotel Information");
            Console.WriteLine("2. Select a Floor");
            Console.WriteLine("3. Book a Room");
            Console.WriteLine("4. Cancel a Room");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    hotel.Display();
                    break;
                case 2:
                    Console.Write("Enter the floor number (1-4): ");
                    int floorNumber = int.Parse(Console.ReadLine());
                    if (floorNumber >= 1 && floorNumber <= 4)
                    {
                        selectedFloor = hotel.floors[floorNumber - 1];
                        Console.WriteLine("You've selected Floor " + floorNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid floor number.");
                    }
                    break;
                case 3:
                    if (selectedFloor != null)
                    {
                        selectedFloor.FindRoomToBook();
                    }
                    else
                    {
                        Console.WriteLine("Please select a floor first.");
                    }
                    break;
                case 4:
                    if (selectedFloor != null)
                    {
                        selectedFloor.FindRoomToCancel();
                    }
                    else
                    {
                        Console.WriteLine("Please select a floor first.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Exiting Room Management Menu.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}


//public class HotelDriver
//{
    //public static void Main(string[] args)
    //{
       // Hotel h1 = new Hotel(101, "The Grand");

       // h1.Display();
        //h1.BookARoom();
       // h1.Display();
       // h1.CancelARoom();
       // h1.Display();
   // }
//}


