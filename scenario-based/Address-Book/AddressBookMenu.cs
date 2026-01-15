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

                Console.WriteLine("============Address Book Menu============:");
                Console.WriteLine("1. Exit.");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Dispaly contacts");
                Console.WriteLine("4. Edit Existing by Name.");
                Console.WriteLine("5. Delete an existing contact by Name.");
                Console.WriteLine("6. Add Multiple Peresons Consecutively.");


                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        return;   // exits menu

                    case 2:
                        addressBookUtility.AddContact();//Adding a new Contact
                        break;

                    case 3:
                        Console.WriteLine("Displaying Contacts");
                        addressBookUtility.DisplayContacts();
                        break;

                    case 4:
                        addressBookUtility.EditExistingContact(); // Editing existing contact
                        break;

                    case 5: addressBookUtility.DeleteContactByName();
                    break;

                    case 6: addressBookUtility.AddMultiplePersons();
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