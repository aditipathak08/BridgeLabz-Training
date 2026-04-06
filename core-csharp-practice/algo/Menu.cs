using System;

class Menu
{
    static void Main()
    {
        MovieBook book = new MovieBook();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Movie Menu:");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Display All Movies");
            Console.WriteLine("3. Search Movie");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter movie title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter show time: ");
                    string time = Console.ReadLine();
                    book.AddMovie(title, time);
                    break;

                case "2":
                    book.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    book.SearchMovie(keyword);
                    break;

                case "4":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }
}
