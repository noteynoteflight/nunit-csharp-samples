namespace nunit_csharp_samples.Tests;

using NUnit.Framework;

[TestFixture]
public class LibraryStatisticsAnalyzerTests
{
    [Test]
    public void GetBooksByAuthor_ReturnsCorrectBooks()
    {

        var analyzer = new LibraryStatisticsAnalyzer();
        var book1 = new Book { Title = "Book 1", Author = "Author 1", Articul = "12345" };
        var book2 = new Book { Title = "Book 2", Author = "Author 2", Articul = "67890" };
        analyzer.Books.AddRange(new List<Book> { book1, book2 });


        var result = analyzer.GetBooksByAuthor("Author 1");


        Assert.AreEqual(1, result.Count);
        Assert.Contains(book1, result);
    }

} }