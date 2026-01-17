using System;

namespace Address_Book
{
    class AddressBookMain
    {
        public static AddressBook[] AddressBooks;
        public static int AddressBookArrayIndex;

        static AddressBookMain()
        {
            AddressBooks = new AddressBook[10];               // max 10 books
            AddressBooks[0] = new AddressBook("default", 10); // default book
            AddressBookArrayIndex = 1;
        }

        static void Main(string[] args)
        {
            AddressBookMenu menu = new AddressBookMenu();
            menu.ShowMenu();
        }
    }
}
