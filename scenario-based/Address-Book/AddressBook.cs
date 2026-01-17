using System;

namespace Address_Book
{
    class AddressBook
    {
        public string BookName { get; set; }
        public int MaxSize { get; }
        public int CurrentIndex { get; set; }
        public Address[] Addresses { get; }

        public AddressBook(string bookName, int maxSize)
        {
            BookName = bookName;
            MaxSize = maxSize;
            Addresses = new Address[maxSize];
            CurrentIndex = 0;
        }

        public override string ToString()
        {
            return $"Book Name: {BookName}, Max Size: {MaxSize}, Current Contacts: {CurrentIndex}";
        }
    }
}
