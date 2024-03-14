/// <summary>
/// A manager for a library's collection of books.
/// </summary>
public class LibraryManager : ILibraryManager
{
    private List<Book> _books;
    /// <summary>
    /// Gets or sets a book articul.
    /// </summary>
    public string Articul { get; set; }
    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        if (!string.IsNullOrEmpty(book.Articul))
        {
            books.Add(book);
            Console.WriteLine($"Book added: {book.Title}");
        }
        else
        {
            Console.WriteLine("Error: Book articul is missing.");
        }
    }

    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public void RemoveBook(Book book)
    {
        // TODO step 1.
    }
}