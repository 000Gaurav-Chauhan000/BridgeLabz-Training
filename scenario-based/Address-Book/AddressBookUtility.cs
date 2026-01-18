using System;

namespace Address_Book
{
    internal class AddressBookUtility
    {
        // helper: find address book by name
        private AddressBook GetAddressBookByName(string bookName)
        {
            for (int i = 0; i < AddressBookMain.AddressBookArrayIndex; i++)
            {
                if (AddressBookMain.AddressBooks[i].BookName
                    .Equals(bookName, StringComparison.OrdinalIgnoreCase))
                {
                    return AddressBookMain.AddressBooks[i];
                }
            }
            return null;
        }

        // helper: ask user which address book to use
        private AddressBook ResolveAddressBook()
        {
            Console.Write("Enter address book name (press enter for default): ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                name = "default";

            AddressBook book = GetAddressBookByName(name);

            if (book == null)
            {
                Console.WriteLine("Address book not found. Using default.");
                book = GetAddressBookByName("default");
            }

            return book;
        }

        public void AddContact()
        {
            AddressBook book = ResolveAddressBook();

            if (book.CurrentIndex >= book.MaxSize)
            {
                Console.WriteLine("Address book is full.");
                return;
            }

            Address address = new Address();

            Console.Write("Enter First Name: ");
            address.FirstName = Console.ReadLine();

            //  checking duplicates by name
            for (int i = 0; i < book.CurrentIndex; i++)
            {
                if (book.Addresses[i].FirstName
                    .Equals(address.FirstName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Duplicate entry not allowed in this address book.");
                    return;
                }
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

            book.Addresses[book.CurrentIndex] = address;
            book.CurrentIndex++;

            Console.WriteLine($"Contact added to '{book.BookName}'.");
        }


        public void DisplayContacts()
        {
            AddressBook book = ResolveAddressBook();

            if (book.CurrentIndex == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            for (int i = 0; i < book.CurrentIndex; i++)
            {
                Console.WriteLine(book.Addresses[i]);
            }
        }

        public void EditExistingContact()
        {
            AddressBook book = ResolveAddressBook();

            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine();

            for (int i = 0; i < book.CurrentIndex; i++)
            {
                if (book.Addresses[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter new Phone Number: ");
                    book.Addresses[i].PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Contact updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        public void DeleteContactByName()
        {
            AddressBook book = ResolveAddressBook();

            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine();

            for (int i = 0; i < book.CurrentIndex; i++)
            {
                if (book.Addresses[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < book.CurrentIndex - 1; j++)
                        book.Addresses[j] = book.Addresses[j + 1];

                    book.Addresses[book.CurrentIndex - 1] = null;
                    book.CurrentIndex--;

                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        public void AddMultiplePersons()
        {
            Console.Write("Enter number of persons to add: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                AddContact();
            }
        }
        public void SearchPersonByCityOrState()
        {
            Console.Write("Enter City or State to search: ");
            string searchKey = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < AddressBookMain.AddressBookArrayIndex; i++)
            {
                AddressBook book = AddressBookMain.AddressBooks[i];

                for (int j = 0; j < book.CurrentIndex; j++)
                {
                    Address address = book.Addresses[j];

                    if (address.City.Equals(searchKey, StringComparison.OrdinalIgnoreCase) ||
                        address.State.Equals(searchKey, StringComparison.OrdinalIgnoreCase))
                    {
                        if (!found)
                        {
                            Console.WriteLine("\n--- Search Results ---");
                            found = true;
                        }

                        Console.WriteLine($"[{book.BookName}] {address.FirstName} {address.LastName}, " + $"{address.City}, {address.State}, {address.PhoneNumber}"
                        );
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No matching persons found.");
            }
        }
        public void ViewPersonsByCityOrState()
        {
            Console.Write("Enter City or State: ");
            string input = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < AddressBookMain.AddressBookArrayIndex; i++)
            {
                AddressBook book = AddressBookMain.AddressBooks[i];

                for (int j = 0; j < book.CurrentIndex; j++)
                {
                    Address address = book.Addresses[j];

                    if (address.City.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                        address.State.Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        if (!found)
                        {
                            Console.WriteLine($"\n--- Persons in {input} ---");
                            found = true;
                        }

                        Console.WriteLine(
                            $"{address.FirstName} {address.LastName} " +
                            $"({book.BookName}) - {address.PhoneNumber}"
                        );
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No persons found for the given City/State.");
            }
        }
        public void CountPersonsByCityOrState()
        {
            Console.Write("Enter City or State to count: ");
            string input = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < AddressBookMain.AddressBookArrayIndex; i++)
            {
                AddressBook book = AddressBookMain.AddressBooks[i];

                for (int j = 0; j < book.CurrentIndex; j++)
                {
                    Address address = book.Addresses[j];

                    if (address.City.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                        address.State.Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Total number of contacts in '{input}' : {count}");
        }
        public void SortEntriesByPersonName()
        {
            AddressBook book = ResolveAddressBook();

            if (book.CurrentIndex == 0)
            {
                Console.WriteLine("No contacts to sort.");
                return;
            }

            // Create a temporary array for sorting
            Address[] temp = new Address[book.CurrentIndex];

            for (int i = 0; i < book.CurrentIndex; i++)
            {
                temp[i] = book.Addresses[i];
            }

            // Simple alphabetical sort (Bubble Sort)
            for (int i = 0; i < temp.Length - 1; i++)
            {
                for (int j = 0; j < temp.Length - i - 1; j++)
                {
                    if (string.Compare(
                            temp[j].FirstName,
                            temp[j + 1].FirstName,
                            StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        Address swap = temp[j];
                        temp[j] = temp[j + 1];
                        temp[j + 1] = swap;
                    }
                }
            }

            Console.WriteLine($"\n--- Sorted Contacts in '{book.BookName}' ---");
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }

    }
}