using System.Collections;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}


class Library : IEnumerable<Book>
{
    List<Book> books = new List<Book>();

    public Book this[int index]
    {
        get { return books[index]; }
        set { books.Insert(index, value); }
    }

    public void Add(Book station)
    {
        books.Add(station);
    }

    public void Remove(Book station)
    {
        books.Remove(station);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    public static void Main(){
        Library library = new Library();

        library.Add(new Book("Book1", "Author1", 1999));
        library.Add(new Book("Book2", "Author2", 2000));
        library.Add(new Book("Book3", "Author3", 2001));

        foreach (var book in library)
        {
            Console.WriteLine($"{book.Title}, автор: {book.Author}, дата публикации: {book.Year}");
        }

    }

}