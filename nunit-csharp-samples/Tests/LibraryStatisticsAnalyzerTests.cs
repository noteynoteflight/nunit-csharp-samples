namespace nunit_csharp_samples.Tests;

public class LibraryStatisticsAnalyzer
{
    public List<Book> GetBooksByAuthor(string author)
    {

        return Books.Where(b => b.Author == author).ToList();
    }

    public Book GetBookByTitle(string title)
    {

        return Books.FirstOrDefault(b => b.Title == title);
    }

    public Book GetBookByArticul(string articul)
    {
        return Books.FirstOrDefault(b => b.Articul == articul);
    }
} }