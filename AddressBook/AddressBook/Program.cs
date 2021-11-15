using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Address Book");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details in specified format");
                        Contact contact = new Contact()
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
                        flag = false;
                        break;
                }
            }
        }
    }
 
}
