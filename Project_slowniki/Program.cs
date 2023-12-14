using System.Globalization;

namespace Project_slowniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Anna");
            d.Add(2, "Czarny niger");
            d.Add(3, "Dawid Jasper");
            d.Add(4, "Czarny niewolnik");

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Value}");
            }
            Console.WriteLine();

            //#############################################

            Dictionary<string, int> d1 = new Dictionary<string, int>();

            d1.Add("jeden", 1);
            d1.Add("dwa", 2);
            d1.Add("trzy", 3);

            foreach (var item in d1)
            {
                Console.WriteLine($"{item.Value}, {item.Key}");
            }
            Console.WriteLine();

            //###############################################

            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Polska", "Warszawa");
            capitals.Add("Niemcy", "Berlin");
            capitals.Add("Bogdan", "Mińsk");

            foreach (KeyValuePair<string, string> item in capitals)
            {
                Console.WriteLine($"{item.Value}");
            }
            Console.WriteLine();

            //###############################################

            Dictionary<string, string> phones = new Dictionary<string, string>()
            {
                { "+48 123 456 789", "Anna" },
                { "+48 123 456 788", "Mamon" },
                { "+48 123 456 787", "kotomiler" }

            };

            foreach (var item in phones)
            {
                Console.WriteLine($"{item.Value}");
            }
            Console.WriteLine();

            //############################################

            Dictionary<string, string> colors = new Dictionary<string, string>()
            {
                { "biały", "#FFFFFF" },
                { "czarny", "#000000" },
                { "czerwony", "#FF0000" },
                { "zielony", "#00FF00" },
                { "niebieski", "#0000FF" }
            };

            foreach (var item in colors)
            {
                Console.WriteLine($"Kolor: {item.Key}, hex: {item.Value}");
            }
            Console.WriteLine();

            //############################################

/* Napisz program, który tworzy słownik typu Dictionary<string, string> i umożliwia użytkownikowi 
* wprowadzenie dowolnej liczby par klucz-wartość.
Następnie program wyświetla wszystkie elementy słownika w formacie: “Klucz: …, wartość: …”.
Użyj pętli for do pobierania danych od użytkownika i pętli foreach do wyświetlania elementów słownika.

Przykład działania programu:

Podaj ile par klucz-wartość chcesz wprowadzić: 3

Podaj klucz: imię
Podaj wartość: Anna
Podaj klucz: kolor
Podaj wartość: niebieski
Podaj klucz: zwierzę
Podaj wartość: kot

Klucz: imię, wartość: Anna
Klucz: kolor, wartość: niebieski
Klucz: zwierzę, wart*/

            Dictionary<string, string> ok = new Dictionary<string, string>();
            Console.WriteLine("podaj ile par klucz-wartosc chcesz prowadzić: ");
            int input = int.Parse( Console.ReadLine() );

            for(int i = 0; i<input; i++)
            {
                Console.WriteLine("Podaj klucz: ");
                string key = Console.ReadLine();
                Console.WriteLine("Podaj wartość");
                string value = Console.ReadLine();

                ok.Add(key, value);
            }

            foreach(var item in ok)
            {
                Console.WriteLine($"Klucz: {item.Key}, Wartosc: {item.Value}");
            }
            Console.WriteLine();



}
}
}
