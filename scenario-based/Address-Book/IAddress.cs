using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    internal interface IAddress{
        void AddContact();
        void EditExistingContact();
        void DisplayContacts();
    }
}
