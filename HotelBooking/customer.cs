using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{
    public class Customer
    {
        private string customerName;
        private string customerEmail;

        public Customer()
        {

        }

        public Customer(string cname, string cemail)
        {
            customerName = cname;
            customerEmail = cemail;
        }

        public void Display()
        {
            Console.WriteLine("Details are " + customerName + " " + customerEmail);
        }

        public void GetName()
        {
            Console.WriteLine("Please enter your name");
            customerName = Console.ReadLine();
        }

        public void GetEmail()
        {
            Console.WriteLine("Please enter your contact details");
            customerEmail = Console.ReadLine();
        }
    }
}