using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    internal class AddressBookUtility : IAddress
    {
        Address[] addresses = new Address[10];
        static int count = 0;

        public void AddContact() //Adding a new Contact
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
                    count++;
                    break;
                }
            }
        }
        public void EditExistingContact()
        {
            Console.WriteLine("Enter Contact Name :");
            string contactName = Console.ReadLine();
            for (int i = 0; i < addresses.Length; i++)
            {
                // updating the contact using name
                if (addresses[i] != null && addresses[i].FirstName.Equals(contactName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contact found. Enter new contact:");
                    addresses[i].PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully.");
                    return;
                }

            }
            Console.WriteLine("Contact not found.");
        }
        public void DisplayContacts() //Displaying Contacts
        {
            if (count == 0)
            {
                System.Console.WriteLine("No contacts available");
                return;
            }
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(addresses[i]);
            }
            return;
        }
    }
}
