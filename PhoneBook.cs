using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_book
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);        
        }

        public void DispalayContactDetails(Contact contact)
        {
            Console.WriteLine($"Dane kontaktowe : Imie {contact.Name}, numer : {contact.Number}");
        }
        public void DispalayContactsDetails(List <Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DispalayContactDetails(contact);
            }

        }

        public void DispalayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Podany kontakt nie znnajduje się w ksiązce adresowej");

            }
            else
            {
                DispalayContactDetails(contact);
            }
        }
        public void DispalayAllContact()
        {
            DispalayContactsDetails(Contacts);

        }
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DispalayContactsDetails(matchingContacts);
        }
    }
}
