// BookShelf – Library Organiz Story: In a library system, books are arranged based on genre and author. A HashMap maps genre → list of books (LinkedList). Each list is dynamically updated when books are borrowed or
// returned.
// Requirements:
// ● Maintain genre-wise catalog.
// ● Efficient insert, delete using LinkedList.
// ● Avoid duplication using HashSet (optional).
using System;

class BookShelf
{
    static string[][][] library = new string[3][][]; // genres
    static int[] bookCount = new int[3];              // count per genre

    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            library[i] = new string[5][]; // max 5 books per genre
        }

        AddBook(0, "Harry Potter", "J K Rowling");
        AddBook(0, "Lord of Rings", "Tolkien");
        AddBook(1, "Brief History of Time", "Stephen Hawking");

        DisplayGenre(0);
        DisplayGenre(1);

        RemoveBook(0, "Harry Potter");
        DisplayGenre(0);
    }

    static void AddBook(int genre, string title, string author)
    {
        if (bookCount[genre] >= 5)
        {
            Console.WriteLine("No space for more books");
            return;
        }

        // duplication check
        for (int i = 0; i < bookCount[genre]; i++)
        {
            if (library[genre][i][0] == title)
            {
                Console.WriteLine("Duplicate book not allowed");
                return;
            }
        }

        library[genre][bookCount[genre]] = new string[2];
        library[genre][bookCount[genre]][0] = title;
        library[genre][bookCount[genre]][1] = author;

        bookCount[genre]++;
        Console.WriteLine("Book Added");
    }

    static void RemoveBook(int genre, string title)
    {
        for (int i = 0; i < bookCount[genre]; i++)
        {
            if (library[genre][i][0] == title)
            {
                for (int j = i; j < bookCount[genre] - 1; j++)
                {
                    library[genre][j] = library[genre][j + 1];
                }

                bookCount[genre]--;
                Console.WriteLine("Book Removed");
                return;
            }
        }

        Console.WriteLine("Book not found");
    }

    static void DisplayGenre(int genre)
    {
        Console.WriteLine("\nBooks in Genre " + genre);

        for (int i = 0; i < bookCount[genre]; i++)
        {
            Console.WriteLine(
                library[genre][i][0] + " - " + library[genre][i][1]   );
        }
    }
}
