using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    class ContactLibrary
    {
        private List<Contact> contacts { get; set; } = new List<Contact>();

        // private function that takes in the contact list as a parameter and outputs the Name and Number to the console.
        private void DisplayContact(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        // takes a list of contacts and display details and loops info to console
        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                DisplayContact(contact);
            }
        }

        //method to add contacts
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            // checks if number is == to a number or null value if contact is not found
            var contact = contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("No found contact.");
            }
            else
            {
                DisplayContact(contact);
            }
        }

        public void DisplayAllContacts()
        {
            // iterate through each contact in the Contact List<> and use the Display method to output the details to the console.
            DisplayContactDetails(contacts);
        }

        // method taking a search phrase as a parameter to match with the contact list
        public void DisplayMatchingContacts(string searchPhrase)
        {
            // storing the search phrase while narrowing down the search phrase using the where clause and the contains method to match phrases then creates a list to pick from.
            var matchingContacts = contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();

            // iterate through each stored value in matching contacts and output to console.
            foreach (var contact in matchingContacts)
            {
                DisplayContact(contact);
            }
        }

    }
}
