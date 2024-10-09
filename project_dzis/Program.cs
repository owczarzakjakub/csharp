using System;
using System.Collections.Generic;

// Klasa bazowa dla osoby
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Konstruktor inicjalizujący pola FirstName i LastName
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

// Klasa reprezentująca autora, dziedziczy po klasie Person
public class Author : Person
{
    public List<Book> BooksList { get; set; }

    // Konstruktor inicjalizujący pola FirstName, LastName oraz pustą listę książek
    public Author(string firstName, string lastName) : base(firstName, lastName)
    {
        BooksList = new List<Book>();
    }

    // Metoda dodająca książkę do listy książek autora
    public void AddBook(Book book)
    {
        BooksList.Add(book);
    }
}

// Klasa reprezentująca książkę
public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }
    public int PublicationYear { get; set; }

    // Konstruktor inicjalizujący pola Title, Author oraz PublicationYear
    public Book(string title, Author author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }
}

// Klasa reprezentująca czytelnika, dziedziczy po klasie Person
public class Reader : Person
{
    public List<Book> BorrowedBooksList { get; set; }

    // Konstruktor inicjalizujący pola FirstName, LastName oraz pustą listę wypożyczeń
    public Reader(string firstName, string lastName) : base(firstName, lastName)
    {
        BorrowedBooksList = new List<Book>();
    }

    // Metoda dodająca książkę do listy wypożyczeń
    public void BorrowBook(Book book)
    {
        BorrowedBooksList.Add(book);
        Console.WriteLine($"Czytelnik {FirstName} {LastName} wypożyczył książkę: {book.Title}");
    }
}

// Klasa reprezentująca bibliotekę
public class Library
{
    public List<Book> BooksList { get; set; }
    public List<Reader> ReadersList { get; set; }
    public List<Author> AuthorsList { get; set; }

    // Konstruktor inicjalizujący pustą listę książek i czytelników
    public Library()
    {
        BooksList = new List<Book>();
        ReadersList = new List<Reader>();
        AuthorsList = new List<Author>();
    }

    // Metoda dodająca książkę do listy książek
    public void AddBook(Book book)
    {
        BooksList.Add(book);
        Console.WriteLine($"Dodano książkę: {book.Title}");
    }

    // Metoda dodająca czytelnika do listy czytelników
    public void AddReader(Reader reader)
    {
        ReadersList.Add(reader);
        Console.WriteLine($"Dodano czytelnika: {reader.FirstName} {reader.LastName}");
    }

    public void addAuthor(Author author)
    {
        AuthorsList.Add(author);
        Console.WriteLine("Dodano autora: " + author.FirstName + " " + author.LastName);
    }

    // Metoda umożliwiająca wypożyczenie książki przez czytelnika
    public void BorrowBook(Reader reader, Book book)
    {
        if (BooksList.Contains(book))
        {
            reader.BorrowBook(book);
            BooksList.Remove(book);
            Console.WriteLine($"Książka {book.Title} została wypożyczona przez {reader.FirstName} {reader.LastName}");
        }
        else
        {
            Console.WriteLine($"Książka {book.Title} nie jest dostępna w bibliotece");
        }
    }

    public void DisplayAuthorsTable()
    {
        Console.WriteLine("Lista autorow");
        Console.WriteLine("ID\timie\tnazwisko");
        for (int i = 0; i < AuthorsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}\t{AuthorsList[i].FirstName}\t{AuthorsList[i].LastName}");
        }
    }
}

// Przykładowe użycie
class Program
{
    static void Main(string[] args)
    {
        // Tworzenie autora
        Author author = new Author("Adam", "Mickiewicz");
        // Tworzenie książki
        Book book = new Book("Pan Tadeusz", author, 1834);
        // Dodawanie książki do listy książek autora
        author.AddBook(book);

        // Tworzenie czytelnika
        Reader reader = new Reader("Jan", "Kowalski");
        // Tworzenie biblioteki
        Library library = new Library();
        // Dodawanie książki do biblioteki
        library.AddBook(book);
        // Dodawanie czytelnika do biblioteki
        library.AddReader(reader);

        // Wypożyczanie książki przez czytelnika
        library.BorrowBook(reader, book);

        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. dodaj autora");
            Console.WriteLine("2. dodaj ksiazke");
            Console.WriteLine("3. dodaj czytelnika");
            Console.WriteLine("8. wyjscie");
            Console.WriteLine("wybierz opcje: ");
            
            string choice = Console.ReadLine();
            switch(choice){
                case "1":
                    Console.WriteLine("Podaj imie autora");
                    string authorFirstName = Console.ReadLine();
                    Console.WriteLine("Podaj nazwisko autora");
                    string authorLastName = Console.ReadLine();
                    library.addAuthor(new Author(authorFirstName, authorLastName));
                    break;
                case "2":
                    library.DisplayAuthorsTable();
                    Console.WriteLine("Podaj numer autora: ");
                    int authorIndex = int.Parse(Console.ReadLine()) - 1;
                    if (authorIndex >= 0 && authorIndex < library.AuthorsList.Count)
                    {
                        s
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidlowy numer autora");
                    }
                    break;

            }
        }

        Console.ReadKey();
    }
}
