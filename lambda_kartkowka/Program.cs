using System.Collections.Generic;
using System.Linq;
using System;
using System.Xml.Serialization;

namespace lambda_kartkowka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int n = ReadInt("Podaj rozmiar tablicy: ", 0, int.MaxValue);
            int[] tab = new int[n];
            tab[0] = 1;
            int it = 0;
            foreach (int i in tab)
            {
                it = it + 1;
                Console.Write(i + ", ");
                if (it == n)
                {
                    Console.WriteLine();
                    it = 0;
                }
            }
            */

            int n = ReadInt("Podaj liczbę osób:", 0, int.MaxValue);
            Console.WriteLine();

            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = ReadString("podaj imie: ");
                ages[i] = ReadInt("podaj wiek: ", 0, 112);
            }
            Console.WriteLine("Persons: ");
            Printarray(names, ages);

            List<string> NamesStartsWitha = names.Where(e => e.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine("Persons which names starts with letter A: ");
            PrintList(NamesStartsWitha);
            Console.WriteLine();

            Dictionary<string, int> adults = new Dictionary<string, int>();
            for (int i = 0;i < n;i++)
            {
                if (ages[i] >= 18)
                {
                    adults.Add(names[i], ages[i]);
                }
            }
            Console.WriteLine("Adults: ");
            PrintDictionary(adults);
            

        }
        static int ReadInt(string prompt, int min, int max)
        {

            bool vaild;
            int result;
            Console.Write(prompt);
            do
            {
                vaild = int.TryParse(Console.ReadLine(), out result) && result >= min && result <= max;
                if (vaild == false || result <= min || result > max)
                {
                    Console.WriteLine($"Podaj liczbe od {min} do {max}");
                }

            } while (vaild == false);
            return result;
        }
        static string ReadString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Podaj nie pusty ciag znaków: ");
                }
            } while (string.IsNullOrEmpty(result));
            return result;
        }
        static void Printarray(string[] names, int[] ages)
        {
            for (int i = 0;i < names.Length;i++)
            {
                Console.WriteLine($"{names[i]} - {ages[i]}");
            }
        }
        static void PrintList(List<string> names)
        {
            foreach (string name in names)
            {
                Console.Write(name + ", ");
            }
        }
        static void PrintDictionary(Dictionary<string, int> adults) {
            
            foreach(var adult in adults)
            {
                Console.WriteLine($"{adult.Key} - {adult.Value}");
            }
            
        }
    }
}