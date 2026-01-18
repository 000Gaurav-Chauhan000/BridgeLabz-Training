namespace Address_Book
{
    class AddressBookMenu
    {
        public void ShowMenu()
        {

            AddressBookUtility addressBookUtility = new AddressBookUtility();

            int choice;

            do
            {
                Console.WriteLine("\n============ Address Book Menu ============");
                Console.WriteLine("1. Exit");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Display Contacts");
                Console.WriteLine("4. Edit Existing Contact by Name");
                Console.WriteLine("5. Delete Contact by Name");
                Console.WriteLine("6. Add Multiple Persons");
                Console.WriteLine("7. Search Person by City or State");
                Console.WriteLine("8. View Persons by City or State");
                Console.WriteLine("9. Count Persons by City or State");
                Console.WriteLine("10. Sort Entries by Person Name");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        return;

                    case 2:
                        addressBookUtility.AddContact();
                        break;

                    case 3:
                        addressBookUtility.DisplayContacts();
                        break;

                    case 4:
                        addressBookUtility.EditExistingContact();
                        break;

                    case 5:
                        addressBookUtility.DeleteContactByName();
                        break;

                    case 6:
                        addressBookUtility.AddMultiplePersons();
                        break;

                    case 7:
                        addressBookUtility.SearchPersonByCityOrState();
                        break;

                    case 8:
                        addressBookUtility.ViewPersonsByCityOrState();
                        break;

                    case 9:
                        addressBookUtility.CountPersonsByCityOrState();
                        break;

                    case 10:
                        addressBookUtility.SortEntriesByPersonName();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (choice != 1);
        }
    }
}