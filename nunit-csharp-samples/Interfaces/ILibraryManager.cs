/// <summary>
/// Defines methods for managing a collection of books in a library.
/// </summary>
public interface ILibraryManager
{
    public class Book
    {
        public string Articul { get; set; }
    }
    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        if (Books.Any(b => b.Articul == book.Articul))
        {
            Console.WriteLine("Error: Book with the same articul already exists.");
            return;
        }

        Books.Add(book);
    }

    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public bool RemoveBook(Book book)
    {
        return Books.Remove(book);
    }
}