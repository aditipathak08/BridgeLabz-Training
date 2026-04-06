using System;

// Main Program
class Program
{
    static void Main()
    {
        MenuDriven();   // Entry point
    }

    static void MenuDriven()
    {
        IBookManager manager = new BookManager();

        while (true)
        {
            Console.WriteLine("\nBookBuddy – Digital Bookshelf");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Sort Books");
            Console.WriteLine("3. Search by Author");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    manager.AddBook(title, author);
                    break;

                case "2":
                    manager.SortBooksAlphabetically();
                    break;

                case "3":
                    Console.Write("Enter author name: ");
                    string searchAuthor = Console.ReadLine();
                    manager.SearchByAuthor(searchAuthor);
                    break;

                case "4":
                    manager.DisplayAllBooks();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice");
            }
        }
    }
}
