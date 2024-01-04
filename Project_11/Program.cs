using System.Globalization;

namespace Project_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt("podaj n: ", 0, int.MaxValue);
            string k = ReadString("podaj k: ");

            /*
             Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i wieków
            osób.
             Użyj tablicy, aby przechować wczytane imiona i wieki.
             Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A.
             Użyj słownika, aby przechować pary (imie, wiek) dla wszystkich osób, których wiek jest
            większy niż 18 lat.
             Wypisz na ekranie zawartość tablicy, listy i słownika.
             */
        }

        static int ReadInt (string prompt, int low, int high)
        {
            int result;
            bool valid;
            do
            {
                Console.WriteLine(prompt);
                valid = int.TryParse(Console.ReadLine(), out result) && result >= low && result <= high;
                if (!valid)
                {
                    Console.WriteLine($"Podaj liczbe z zakresu {low} - {high}");
                }
            } while (!valid);
            return result;
        }
        static string ReadString (string prompt)
        {
            bool valid;
            do
            {
                Console.WriteLine(prompt);
                var result = Console.ReadLine();
                if (result.GetType() == typeof(int))
                {
                    valid = false;
                }
                else
                {
                    return result;
                }
            } while (valid == false);
            return null;

        }
    }
}
