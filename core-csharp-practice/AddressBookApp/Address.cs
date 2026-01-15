using System;

class Address
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        AdBook myBook = new AdBook();

        while (true)
        {
            Console.WriteLine("\n--- Address Book Menu ---");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Display All Contacts");
            Console.WriteLine("5. Exit");

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("First Name: ");
                    string first = Console.ReadLine();

                    Console.Write("Last Name: ");
                    string last = Console.ReadLine();

                    Console.Write("Address: ");
                    string addr = Console.ReadLine();

                    Console.Write("City: ");
                    string city = Console.ReadLine();

                    Console.Write("State: ");
                    string state = Console.ReadLine();

                    Console.Write("Zip: ");
                    string zip = Console.ReadLine();

                    Console.Write("Phone: ");
                    string phone = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Contact c = new Contact(first, last, addr, city, state, zip, phone, email);
                    myBook.AddContact(c);
                    break;

                case "2":
                    Console.Write("Enter keyword to edit contact: ");
                    myBook.EditContact(Console.ReadLine());
                    break;

                case "3":
                    Console.Write("Enter keyword to delete contact: ");
                    myBook.DeleteContact(Console.ReadLine());
                    break;

                case "4":
                    myBook.DisplayAll();
                    break;

                case "5":
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }
}
