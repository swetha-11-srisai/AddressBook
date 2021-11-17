using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddContact
    {
        List<Contact> addressbook = new List<Contact>();
        Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();
/// <summary>
/// this method is responsible for adding of contact details
/// </summary>
/// <param name="contact"></param>
        public void AddConctact(Contact contact)
        {
            addressbook.Add(contact);
        }
        /// <summary>
        /// this method is responsible for editing the particular contact detail
        /// </summary>
        /// <param name="name"></param>
        public void EditContact(string name)
        {
            foreach (var contact in addressbook)
            {
                if (contact.firstName == name || contact.lastName == name)
                {
                    Console.WriteLine("contacts will be edited");
                }
            }

        }
        /// <summary>
        /// This method is responsible for deleting the contact of customer
        /// </summary>
        /// <param name="username"></param>
        public void DeleteContact(string username)
        {
            foreach (var contact in addressbook)
            {
                if (contact.firstName == username || contact.lastName == username)
                {
                    addressbook.Remove(contact);
                }
            }

        }
        public void AddUniqueContact(string nam)
        {
            foreach (var contact in addressbook)
            {
                if (addressbook.Contains(contact))
                {
                    string uniqueName = Console.ReadLine();
                    dict.Add(uniqueName, addressbook);
                }
            }
        }
        public void DisplayUniqueContacts()
        {
            // Maintain Dictionary of Addressbook Name to Addressbook
            Console.WriteLine("enter name of dictionary to display that contact details");
            string name = Console.ReadLine();
            foreach (var contacts in dict)
            {
                if (contacts.Key == name)
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact of " + data.firstName + " Details are\n:" + data.firstName + " " + data.lastName + " " + data.address + " " + data.city + " " + data.state + " " + data.zip + " " + data.phoneNumber + " " + data.email);
                    }
                }
            }
            Console.WriteLine("Oops UniqueContacts does not exist!! Please create a UniquecontactList");
            return;
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
