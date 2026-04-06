using System;

// Interface
interface IBookManager
{
    void AddBook(string title, string author);
    void SortBooksAlphabetically();
    void SearchByAuthor(string author);
    void DisplayAllBooks();
}

// Book class
class Book
{
    public string Data { get; set; }   // "Title - Author"

    public Book(string title, string author)
    {
        Data = title + " - " + author;
    }

    public string GetTitle()
    {
        string[] parts = Data.Split('-');
        return parts[0].Trim();
    }

    public string GetAuthor()
    {
        string[] parts = Data.Split('-');
        return parts[1].Trim();
    }
}

// Collection class (array-based)
class BookCollection
{
    private Book[] books;
    private int count;
    private int capacity;

    public BookCollection()
    {
        capacity = 2;
        books = new Book[capacity];
        count = 0;
    }

    public void Add(Book book)
    {
        if (count == capacity)
        {
            capacity = capacity * 2;
            Book[] newBooks = new Book[capacity];
            for (int i = 0; i < count; i++)
            {
                newBooks[i] = books[i];
            }
            books = newBooks;
        }

        books[count] = book;
        count++;
    }

    public int Count()
    {
        return count;
    }

    public Book GetBook(int index)
    {
        if (index >= 0 && index < count)
            return books[index];
        return null;
    }

    public Book[] GetBooks()
    {
        return books;
    }
}

// Manager class
class BookManager : IBookManager
{
    private BookCollection collection;

    public BookManager()
    {
        collection = new BookCollection();
    }

    public void AddBook(string title, string author)
    {
        Book book = new Book(title, author);
        collection.Add(book);
        Console.WriteLine("Book added successfully.\n");
    }

    public void SortBooksAlphabetically()
    {
        for (int i = 0; i < collection.Count() - 1; i++)
        {
            for (int j = i + 1; j < collection.Count(); j++)
            {
                Book b1 = collection.GetBook(i);
                Book b2 = collection.GetBook(j);

                if (string.Compare(b1.GetTitle(), b2.GetTitle(), true) > 0)
                {
                    // swap
                    Book temp = b1;
                    collection.GetBooks()[i] = b2;
                    collection.GetBooks()[j] = temp;
                }
            }
        }
        Console.WriteLine("Books sorted alphabetically.\n");
    }

    public void SearchByAuthor(string author)
    {
        bool found = false;
        Console.WriteLine("Search results:");

        for (int i = 0; i < collection.Count(); i++)
        {
            Book book = collection.GetBook(i);
            if (book.GetAuthor().ToLower().Contains(author.ToLower()))
            {
                Console.WriteLine(book.Data);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No books found by this author.");

        Console.WriteLine();
    }

    public void DisplayAllBooks()
    {
        if (collection.Count() == 0)
        {
            Console.WriteLine("No books available.\n");
            return;
        }

        Console.WriteLine("All Books:");
        for (int i = 0; i < collection.Count(); i++)
        {
            Console.WriteLine((i + 1) + ". " + collection.GetBook(i).Data);
        }
        Console.WriteLine();
    }
}
