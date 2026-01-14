using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
//Encapsulated class 
    public class Address
    {
        public string FirstName { get; set; }
         public string LastName { get; set; }
         public string City { get; set; }
         public string State { get; set; }
         public string ZipCode { get; set; }
         public string PhoneNumber { get; set; }
         public string Email{ get; set; }
         
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {City}, {State}, {ZipCode}, {PhoneNumber}, {Email}";
        }
    }
}