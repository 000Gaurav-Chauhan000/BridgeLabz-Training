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

                System.Console.WriteLine("============Address Book Menu============:");
                System.Console.WriteLine("1. Add Contact");
                System.Console.WriteLine("2. Dispaly contacts");
                System.Console.WriteLine("3. Edit Existing by Name.");
                System.Console.WriteLine("4. Exit.");


               choice= Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBookUtility.AddContact();//Adding a new Contact
                        break;

                    case 2:
                        Console.WriteLine("Displaying Contacts");
                        addressBookUtility.DisplayContacts();
                        break;

                    case 3:
                        addressBookUtility.EditExistingContact(); // Editing existing contact
                        break;

                    case 4:
                        return;   // exits menu

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }}
            while (choice!=4);
            
        }
    }
}