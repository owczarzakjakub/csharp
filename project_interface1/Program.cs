using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_interface1
{
    class Book : IComparable<Book>
    {
        string Title;
        public string Author;
        public int YearOfPublication;
        public double Price;

        public Book(string title, string author, int yearofpublication, double price)
        {
            title = Title;
            author = Author;
            yearofpublication = YearOfPublication;
            price = Price;
        }
        public override string ToString()
        {
            return $"{Title}, {Author}, {YearOfPublication}, {Price}";
        }
        public int CompareTo(Book other)
        {
            return Price.CompareTo(other.Price);
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("aaa", "aa bbb", 1989, 22.34));
            books.Add(new Book("hobbit", "kotomiler vampir", 1988, 22.43));
            books.Add(new Book("kkkk", "jan kotomiler", 1889, 22.44));

            Console.WriteLine("Lista ksiazek: ");
            foreach(Book book in books)
            {
                Console.WriteLine(book.ToString());
            }

            books.Sort();

            Console.WriteLine("\nLista posortowanych ksiazek: ");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nPosortowane wg. daty: ");
            var sortedByYear = books.OrderBy(b => b.YearOfPublication);
            foreach (Book book in sortedByYear)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nPosortowane wg. autora: ");
            var sortedByAuthor = books.OrderByDescending(b => b.Author);
            foreach (Book book in sortedByAuthor)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nSorotwanie wg. ceny nierosnaco, a nastepnie wg. roku publikacji od najsatrszej ksiazki: ");
            var sortedByPrice = books.OrderByDescending(b => b.Price).ThenBy(b => b.YearOfPublication);
            foreach (Book book in sortedByAuthor)
            {
                Console.WriteLine(book);
            }

            Console.ReadKey();
        }
    }
}

