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
            Console.WriteLine($"Ksiazka o tytule {book.Title} zostala wypozyczona przez {FirstName}");
        }

    }
    public class Library
    {
        public List<Book> BooksList { get; set; }
        public List<Reader> ReadersList { get; set; }

        public Library()
        {
            BooksList = new List<Book>();
            ReadersList = new List<Reader>();
        }

        public void addBooks(Book book)
        {
            BooksList.Add(book);
            Console.WriteLine($"Dodano ksiazke o tytule {book.Title} do biblioteki");
        }

        public void addReaders(Reader reader)
        {
            ReadersList.Add(reader);
            Console.WriteLine($"Czytelnik {reader.FirstName} {reader.LastName} zostal dodany do biblioteki");
        }

        public void BorrowBook(Reader reader, Book book)
        {
            if (BooksList.Contains(book))
            {
                reader.BorrowBook(book);
                BooksList.Remove(book);
                
            }
            else{
                Console.WriteLine("Ksiazka jest niedostepna");
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Adam", "Mickiewicz");
            Book book = new Book("Pan Tadeusz", author, 1834);
            author.AddBook(book);

            Reader reader = new Reader("kotomiler", "wampir");
            reader.BorrowBook(book);
            
            Library library = new Library();
            library.addReaders(reader);
            library.addBooks(book);
            library.BorrowBook(reader, book);

            Console.ReadKey();
        }
    }
}