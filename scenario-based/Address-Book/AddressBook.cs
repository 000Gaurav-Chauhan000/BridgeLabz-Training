using System;
namespace Address_Book
{
    public class AddressBook
    {
        public string Name { get; }

        private Address[] addresses = new Address[10];
        private int count = 0;

        public AddressBook(string name)
        {
            Name = name;
        }
    }

}
