<!-- Assisted Problems
Problem 1: Library and Books (Aggregation)
Description: Create a Library class that contains multiple Book objects. Model the relationship such that a library can have many books, but a book can exist independently (outside of a specific library).
Tasks:
Define a Library class with a List<Book> collection.
Define a Book class with attributes such as Title and Author.
Demonstrate the aggregation relationship by creating books and adding them to different libraries.
Goal: Understand aggregation by modeling a real-world relationship where the Library aggregates Book objects. -->

using System;
using System.Collections.Generic;
class Book
{
   public string Title;
   public string Author;
}
class Library
{
   public String name;
    public List<Book> Books;
}
class Program
{
    static void Main()
    {
        Book b1 = new Book();
        b1.Title = "The Alchemist";
        b1.Author = "Paulo Coelho";

        Book b2 = new Book();
        b2.Title = "Clean Code";
        b2.Author = "Robert C. Martin";      
        
    }
}