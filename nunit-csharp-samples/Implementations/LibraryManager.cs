using System;
using System.Collections.Generic;

public class LibraryManager
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException(nameof(book), "Cannot add a null book.");
        }

        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }

    public void RemoveBook(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException(nameof(book), "Cannot remove a null book.");
        }

        if (books.Remove(book))
        {
            Console.WriteLine($"Book '{book.Title}' removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book '{book.Title}' not found in the library.");
        }
    }
}