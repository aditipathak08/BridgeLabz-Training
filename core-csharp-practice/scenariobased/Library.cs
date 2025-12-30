/*
3. Library Management System – Book Search and Checkout
Scenario: You’re designing a system for a small library to manage books and track checkouts.
Problem Requirements:
● Store book details (title, author, status) in a Array.
● Allow searching by partial title using String operations.
● Store book data in an Array.
● Use methods for searching, displaying, and updating book status (checked out or
available).*/        
using System;
class Library{
    private static String [] Books={
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
private static String [] author={
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
private bool [] Status=new bool[10];

private static Display()
{
for(int i=0;i<Books.Length;i++)
{
    Console.WriteLine(Books[i] + author[i]);
}
}
}
