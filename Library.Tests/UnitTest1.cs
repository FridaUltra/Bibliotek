namespace Library.Tests;

public class LibraryTests
{
    [Fact]
    public void AddBook_book_ShouldAddBookToList()
    {
        // Arrange
        Catalogue ca = new Catalogue();
        Book book = new Book("Sara ute och går", "Amanda Abrahamsson", "2021");

        // Act
        ca.AddBook(book);
        //  List<Book> booksAddedToLibrary = ca.GetAllBooks();

        // Assert

        Assert.True(ca.GetAllBooks().Count() == 1);
    }

    [Fact]
    public void SearchForBook_searchString_ShouldReturnFoundBooks()
    {
        // Arrange
        Catalogue ca = new Catalogue();

        ca.AddBook(new Book("Saras äventyr", "Kristina Svensson", "2014"));
        ca.AddBook(new Book("Harry Potter - De vises sten", "J.K Rowling", "2012"));
        ca.AddBook(new Book("Harry Potter - Flammande bägaren", "J.K Rowling", "2015"));
        ca.AddBook(new Book("Bamse", "Tomas Svensson", "2012"));

        int expected = 2;

        // Act
        List<Book> foundBooks = ca.SearchForBook("Harry");
        int actual = foundBooks.Count();


        // Assert
        Assert.Equal(expected, actual);


    }


}