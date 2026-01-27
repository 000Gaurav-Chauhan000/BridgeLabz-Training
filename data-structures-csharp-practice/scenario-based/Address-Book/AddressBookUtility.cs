// AddressBookUtility.cs
using System;
using System.Collections.Generic;

namespace Address_Book
{
    internal class AddressBookUtility
    {
        private AddressBook GetAddressBookByName(string bookName)
        {
            foreach (var book in AddressBookMain.AddressBooks)
            {
                if (book.BookName.Equals(bookName, StringComparison.OrdinalIgnoreCase))
                    return book;
            }
            return null;
        }

        private AddressBook ResolveAddressBook()
        {
            Console.Write("Enter address book name (press enter for default): ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                name = "default";

            AddressBook book = GetAddressBookByName(name);

            if (book == null)
                book = GetAddressBookByName("default");

            return book;
        }

        public void AddContact()
        {
            AddressBook book = ResolveAddressBook();
            Address address = new Address();

            Console.Write("Enter First Name: ");
            address.FirstName = Console.ReadLine();

            foreach (var a in book.Addresses)
            {
                if (a.FirstName.Equals(address.FirstName, StringComparison.OrdinalIgnoreCase))
                    return;
            }

            Console.Write("Enter Last Name: ");
            address.LastName = Console.ReadLine();
            Console.Write("Enter City: ");
            address.City = Console.ReadLine();
            Console.Write("Enter State: ");
            address.State = Console.ReadLine();
            Console.Write("Enter Zip Code: ");
            address.ZipCode = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            address.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Email: ");
            address.Email = Console.ReadLine();

            book.Addresses.AddLast(address);
        }

        public void DisplayContacts()
        {
            AddressBook book = ResolveAddressBook();
            foreach (var address in book.Addresses)
                Console.WriteLine(address);
        }

        public void EditExistingContact()
        {
            AddressBook book = ResolveAddressBook();
            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine();

            foreach (var address in book.Addresses)
            {
                if (address.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter new Phone Number: ");
                    address.PhoneNumber = Console.ReadLine();
                    return;
                }
            }
        }

        public void DeleteContactByName()
        {
            AddressBook book = ResolveAddressBook();
            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine();

            var node = book.Addresses.First;
            while (node != null)
            {
                if (node.Value.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    book.Addresses.Remove(node);
                    return;
                }
                node = node.Next;
            }
        }

        public void AddMultiplePersons()
        {
            Console.Write("Enter number of persons to add: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
                AddContact();
        }

        public void SearchPersonByCityOrState()
        {
            Console.Write("Enter City or State to search: ");
            string key = Console.ReadLine();

            foreach (var book in AddressBookMain.AddressBooks)
            {
                foreach (var address in book.Addresses)
                {
                    if (address.City.Equals(key, StringComparison.OrdinalIgnoreCase) ||
                        address.State.Equals(key, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(address);
                    }
                }
            }
        }

        public void ViewPersonsByCityOrState()
        {
            Console.Write("Enter City or State: ");
            string input = Console.ReadLine();

            foreach (var book in AddressBookMain.AddressBooks)
            {
                foreach (var address in book.Addresses)
                {
                    if (address.City.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                        address.State.Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(address);
                    }
                }
            }
        }

        public void CountPersonsByCityOrState()
        {
            Console.Write("Enter City or State to count: ");
            string input = Console.ReadLine();
            int count = 0;

            foreach (var book in AddressBookMain.AddressBooks)
            {
                foreach (var address in book.Addresses)
                {
                    if (address.City.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                        address.State.Equals(input, StringComparison.OrdinalIgnoreCase))
                        count++;
                }
            }

            Console.WriteLine(count);
        }

        public void SortEntriesByPersonName()
        {
            AddressBook book = ResolveAddressBook();
            List<Address> list = new List<Address>(book.Addresses);
            list.Sort((a, b) => string.Compare(a.FirstName, b.FirstName, StringComparison.OrdinalIgnoreCase));

            foreach (var address in list)
                Console.WriteLine(address);
        }
    }
}
