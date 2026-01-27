namespace Address_Book
{
    internal interface IAddress{
        void AddContact();
        void EditExistingContact();
        void DisplayContacts();
        void AddMultiplePersons();
        void SearchPersonByCityOrState();
        void ViewPersonsByCityOrState();
        void CountPersonsByCityOrState();
        void SortEntriesByPersonName();
    }
}
