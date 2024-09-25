using System.Runtime.ExceptionServices;

namespace project_dziedziczenieKompozycjaBibliotek
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Author : Person
    {
        public List<Book> BooksList { get; set; }
        public Author(string firstname, string lastName) : base(firstname, lastName)
        {
            BooksList = new List<Book>();
        }
        public void AddBook(Book book)
        {
            BooksList.Add(book);
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int PublicationYear { get; set; }
        public Book(string title, Author author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }
    }
    public class Reader : Person
    {
        public List<Book> BorrowedBookList { get; set; }

        public Reader(string firstName, string lastName) : base(firstName, lastName)
        {
            BorrowedBookList = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            BorrowedBookList.Add(book);
            Console.WriteLine($"Ksiazka {book} zostala wypozyczona");
        }

    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Adam", "Mickiewicz");
            Book book = new Book("Pan Tadeusz", author, 1834);
            author.AddBook(book);

            Console.ReadKey();
        }
    }
}
