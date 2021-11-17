using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            AddContact add = new AddContact();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Address Book");
                Console.WriteLine("Enter what you want to do : 1. Create Contacts ,2.Add Contact,3.Edit contact,4.DeleteContacct,5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details");
                        Contact newContact = new Contact()
                        {
                            firstName = Console.ReadLine(),
                            lastName = Console.ReadLine(),
                            address = Console.ReadLine(),
                            city = Console.ReadLine(),
                            state = Console.ReadLine(),
                            zip = Console.ReadLine(),
                            phoneNumber = Console.ReadLine(),
                            email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Add Contact details");
                        contact.firstName = Console.ReadLine();
                        contact.lastName = Console.ReadLine();
                        contact.address = Console.ReadLine();
                        contact.city = Console.ReadLine();
                        contact.state = Console.ReadLine();
                        contact.zip = Console.ReadLine();
                        contact.phoneNumber = Console.ReadLine();
                        contact.email = Console.ReadLine();
                        add.AddConctact(contact);
                        add.Display();
                        break;
                    case 3:
                        Console.WriteLine("enter what is to be edited");
                        contact.firstName = Console.ReadLine();
                        contact.lastName = Console.ReadLine();
                        contact.address = Console.ReadLine();
                        contact.city = Console.ReadLine();
                        contact.state = Console.ReadLine();
                        contact.zip = Console.ReadLine();
                        contact.phoneNumber = Console.ReadLine();
                        contact.email = Console.ReadLine();
                        string name = Convert.ToString(Console.ReadLine());
                        add.EditContact(name);
                        add.Display();
                        break;
                    case 4:
                        Console.WriteLine("enter what is to be deleted");
                        contact.firstName = Console.ReadLine();
                        contact.lastName = Console.ReadLine();
                        contact.address = Console.ReadLine();
                        contact.city = Console.ReadLine();
                        contact.state = Console.ReadLine();
                        contact.zip = Console.ReadLine();
                        contact.phoneNumber = Console.ReadLine();
                        contact.email = Console.ReadLine();
                        string username = Convert.ToString(Console.ReadLine());
                        add.DeleteContact(username);
                        add.Display();
                        break;

                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
 
}
