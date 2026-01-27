// AddressBookMain.cs
namespace Address_Book
{
    class AddressBookMain
    {
        public static LinkedList<AddressBook> AddressBooks;

        static AddressBookMain()
        {
            AddressBooks = new LinkedList<AddressBook>();
            AddressBooks.AddLast(new AddressBook("default"));
        }

        static void Main(string[] args)
        {
            AddressBookMenu menu = new AddressBookMenu();
            menu.ShowMenu();
        }
    }
}
