using System;

namespace Phone_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Książka telefoniczna ");
            Console.WriteLine("1 Dodawanie kontaktów");
            Console.WriteLine("2 Znajdz kontakt po numerze ");
            Console.WriteLine("3 WYświetl całą liste kontaktów");
            Console.WriteLine("4 wyszukowanie kontaktów ");
            Console.WriteLine("x aby wyjść wciśniej   ");
            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine(" Wprowadź numer");
                        var number = Console.ReadLine();
                        Console.WriteLine(" Wprowadź Imie");
                        var name = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Wprowadź numer");
                        var numberToSearch = Console.ReadLine();
                        phoneBook.DispalayContact(numberToSearch);
                        break;
                    case "3":
                        phoneBook.DispalayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Wpisz ywszukiwaną fraze");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("niezrozumiała kompnda");
                        break;
                }
                Console.WriteLine("Wybierz czynność");
                userInput = Console.ReadLine();
            }


            

        }
    }
}
