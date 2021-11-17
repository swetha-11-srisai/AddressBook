using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddContact
    {
        List<Contact> addressbook = new List<Contact>();
       
        public void AddConctact(Contact contact)
        {
            addressbook.Add(contact);
        }
      
        public void Display()
        {
            foreach (var contact in addressbook)
            {
                Console.WriteLine(contact.firstName + "" + contact.lastName + "" + contact.address + "" + contact.city + "" + contact.state + "" + contact.zip + "" + contact.phoneNumber + "" + contact.email);
            }
            
        }
       
    }
}
