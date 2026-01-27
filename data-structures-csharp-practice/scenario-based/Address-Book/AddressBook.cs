// AddressBook.cs
using System.Collections.Generic;

namespace Address_Book
{
    class AddressBook
    {
        public string BookName { get; set; }
        public LinkedList<Address> Addresses { get; }

        public AddressBook(string bookName)
        {
            BookName = bookName;
            Addresses = new LinkedList<Address>();
        }

        public override string ToString()
        {
            return $"Book Name: {BookName}, Current Contacts: {Addresses.Count}";
        }
    }
}
