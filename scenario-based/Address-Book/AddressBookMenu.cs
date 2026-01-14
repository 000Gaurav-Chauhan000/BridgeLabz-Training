namespace Address_Book
{
    class AddressBookMenu
    {
        public void ShowMenu()
        {
            System.Console.WriteLine("============Address Book Menu============:");
            System.Console.WriteLine("1. Add Contact");
           
           int choice = Convert.ToInt32(Console.ReadLine());
            AddressBookUtility addressBookUtility = new AddressBookUtility();

            switch (choice)
            {
                case 1:
                    addressBookUtility.AddContact();
                    break;
               
                default:
                    System.Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}