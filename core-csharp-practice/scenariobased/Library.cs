using System;

class Library
{
    private string[] books = {
        "Harry Potter",
        "The Alchemist",
        "Wings of Fire",
        "The Jungle Book",
        "Rich Dad Poor Dad",
        "The Secret",
        "Think and Grow Rich",
        "The Diary of a Young Girl",
        "The Hobbit",
        "Atomic Habits"
    };

    private string[] authors = {
        "J.K. Rowling",
        "Paulo Coelho",
        "A.P.J. Abdul Kalam",
        "Rudyard Kipling",
        "Robert T. Kiyosaki",
        "Rhonda Byrne",
        "Napoleon Hill",
        "Anne Frank",
        "J.R.R. Tolkien",
        "James Clear"
    };

    private bool[] available = new bool[10];

    // Constructor
    public Library()
    {
        for (int i = 0; i < available.Length; i++)
            available[i] = true;
    }

    // Display all books
    public void Display()
    {
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i] + " - " + authors[i] + " - " +
                (available[i] ? "Available" : "Checked Out"));
        }
    }

    // Search book
    public void Search(string name)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].ToLower().Contains(name.ToLower()))
            {
                Console.WriteLine(books[i] + " - " +
                    (available[i] ? "Available" : "Checked Out"));
            }
        }
    }

    // Checkout book
    public void Checkout(string name)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                if (available[i])
                {
                    available[i] = false;
                    Console.WriteLine("Book checked out");
                }
                else
                {
                    Console.WriteLine("Book already taken");
                }
                return;
            }
        }
        Console.WriteLine("Book not found");
    }
}

class Program
{
    static void Main()
    {
        Library lib = new Library();

        lib.Display();
        Console.WriteLine();

        lib.Search("Harry");
        Console.WriteLine();

        lib.Checkout("Harry Potter");
        Console.WriteLine();

        lib.Display();
    }
}
