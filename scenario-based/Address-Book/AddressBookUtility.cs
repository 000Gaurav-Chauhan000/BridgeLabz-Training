using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    internal class AddressBookUtility
    {
        Address[] addresses = new Address[10];

        public void AddContact()
        {
            Address address = new Address();

            Console.WriteLine("Enter First Name:");
            address.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            address.LastName = Console.ReadLine();

            Console.WriteLine("Enter City:");
            address.City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            address.State = Console.ReadLine();

            Console.WriteLine("Enter Zip Code:");
            address.ZipCode = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            address.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            address.Email = Console.ReadLine();

            for (int i = 0; i < addresses.Length; i++)
            {
                if (addresses[i] == null)
                {
                    addresses[i] = address;
                    break;
                }
            }
        }

    }
}
