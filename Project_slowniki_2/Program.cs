using static System.Formats.Asn1.AsnWriter;

namespace Project_slowniki_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("wprowadz liczbe n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.ReadKey();

            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Podaj imie osoby {i + 1}: ");
                names[i] = Console.ReadLine();
                Console.WriteLine($"Podaj wiek osoby {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());
            }
            List<string> Nameswithstartsa = new List<string>();

            for (int i = 0;i < n; i++)
            {
                if (names[i].StartsWith("a"))
                {
                    Nameswithstartsa.Add(names[i]);
                }
            }

            Dictionary<string, int> adults = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                if (ages[i] >= 18)
                {
                    adults.Add(names[i], ages[i]);
                }
            }

            Console.WriteLine("tablica imion i wieków: ");
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine($"{names[i]} - {ages[i]}");
            }

            Console.WriteLine("lista imioon na litere a: ");
            foreach(var name in Nameswithstartsa)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("slownik osob pelnoletnich");
            foreach (var pair in adults)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            */

            Console.WriteLine("podaj liczbe");
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            int[] ages = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Podaj imie osoby {i + 1}: ");
                names[i] = Console.ReadLine();
                Console.WriteLine($"Podaj wiek osoby {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());
            }

            //nie dziala to nizej

            IEnumerable<string> NameStartsA =
                from name in names
                 where name.StartsWith("A")
                 select name;

            foreach (var name in NameStartsA )
            {
                Console.WriteLine($"imie na a: {name}");
            }





            /*Zadanie: Napisz program w języku C#, który:
             Wczytuje liczbę n, oznaczającą ilość osób, których dane chcesz wprowadzić.
             Tworzy tablicę imion i wieków tych osób, wczytując je z konsoli.
             Tworzy listę imion zaczynających się na literę A, używając wyrażeń LINQ.
             Tworzy słownik par (imie, wiek) dla osób pełnoletnich, używając wyrażeń LINQ.
             Wypisuje zawartość tablicy, listy i słownika na konsoli, używając funkcji pomocniczych.
            Wskazówki:
             Użyj funkcji int.Parse lub int.TryParse, aby zamienić ciąg znaków na liczbę całkowitą.
             Użyj metody StartsWith z parametrem StringComparison, aby sprawdzić, czy ciąg
            znaków zaczyna się od określonego znaku lub ciągu znaków, niezależnie od wielkości
            liter.
             Użyj metody Zip, aby połączyć dwie sekwencje w jedną sekwencję par.
             Użyj metod Where, ToList i ToDictionary, aby filtrować, sortować i transformować
            dane za pomocą wyrażeń LINQ.
             Użyj pętli for lub foreach, aby iterować po elementach kolekcji.
             Użyj znaku $, aby tworzyć łańcuchy znaków interpolowanych, które mogą zawierać
            wartości zmiennych lub wyrażeń.*/
        }
    }
}
