using System;

namespace ContactBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact Book App");
            Console.WriteLine("Select operation");
            Console.WriteLine("1 Add a contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 View all contacts");
            Console.WriteLine("4 Search for contacts by name");
            Console.WriteLine("Type \"0\" to quit");

            var userInput = Console.ReadLine();

            var contactLibrary = new ContactLibrary();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number:");
                        var number = Console.ReadLine();
                        // create new contact instance 
                        var newContact = new Contact(name, number);
                        contactLibrary.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Contact number:");
                        var searchNumber = Console.ReadLine();
                        contactLibrary.DisplayContact(searchNumber);
                        break;
                    case "3":
                        contactLibrary.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();
                        contactLibrary.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "0":
                        //exits the loop
                        return;
                    default:
                        Console.WriteLine("Please select a valid operation...");
                        break;
                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        }
    }
}
