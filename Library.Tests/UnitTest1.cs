namespace Library.Tests;

public class UnitTest1
{
    [Fact]
    public void AddBook_book_ShouldAddBookToList()
    {
        // Arrange
        Catalogue ca = new Catalogue();
        Book book = new Book("Sara ute och går", "Amanda Abrahamsson", "2021");

        // Act
        ca.AddBook(book);
        List<Book> booksAddedToLibrary = ca.GetAllBooks();

        // Assert

        Assert.True(booksAddedToLibrary.Count() == 1);
    }
}