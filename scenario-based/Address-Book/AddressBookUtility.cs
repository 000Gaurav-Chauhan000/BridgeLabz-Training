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
    }
}