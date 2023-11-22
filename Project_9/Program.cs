using System;
namespace project_9
{
    public class Program
    {
        static void Main(string[] args)

        {
            int[] tabA = CreateArray("tabA");
            if (tabA == null)
            {
                SetArray(tabA, "tabA");
                DisplayArray(tabA, "tabA");
            }
        }
        public static int[] CreateArray(string name)
        {
            Console.WriteLine($"Podaj rozmiar tablicy {name} <0 ; {int.MaxValue}> : ");
            int size = 0;
            try
            {
                size = int.Parse(Console.ReadLine());

                if (size <= 0)
                {
                    throw new ArgumentException("Podaj liczbę większą od 0");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: nieprawidłowy format");
                return null;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
                return null;
            }

            int[] array = new int[size];
            return array;


        }

        public static void SetArray(int[] tab, string name)
        {
            Console.WriteLine($"\nPodaj {tab.Length} liczb całkowitych dla tablicy o nazwie {name}");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"Podaj {i + 1} element tablicy: ");
                try
                {
                    tab[i] = int.Parse(Console.ReadLine());
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }

            }


        }

        public static void DisplayArray(int[] tab, string name)
        {
            Console.WriteLine($"\nZawartość tablicy {name}: ");
            int i = 0;
            foreach (int item in tab)
            {
                Console.WriteLine($"{name}[{i}]: {item}");
                i++;
            }
        }
    }
}