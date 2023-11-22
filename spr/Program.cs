using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Xml;

namespace spr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = createarray("array");
            bool Iscorrect = false;

            Console.WriteLine("podaj 10 liczb calkowitych");
            do
            {
                try
                {

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"podaj element o indeksie {i}:");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    //int d;
                    //d = int.Parse(Console.ReadLine());
                    Iscorrect = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("podaj poprawny format danych");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"podano bledny zakres liczby, podaj liczbe od {int.MinValue} do {int.MaxValue}");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!Iscorrect);
            string input;
            int index;
            bool Iscorrect2 = false;
            do
            {
                Console.WriteLine("podaj numer indeksu lub quit aby zakonczyc program");
                try
                {
                    input = Console.ReadLine();
                    if (input == "quit")
                    {
                        break;
                    }
                    index = int.Parse(input);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"element tablicy o indeksie {index} to {array[index]}");
                    Console.ResetColor ();
                    Iscorrect2 = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("podaj poprawny format danych");
                    Console.ResetColor();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"podaj index od 0 do {array.Length-1}");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"podano bledny zakres liczby");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!Iscorrect2);

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"Średnia arytmetyczna wynosi: {srednia(array):F3}");
            Console.ResetColor();

            static double srednia(int[] tablica)
            {   
                double suma = 0;
                for(int i = 0; i<tablica.Length; i++)
                {
                    suma = suma + tablica[i];
                }
                double srednia;
                srednia = suma/tablica.Length;
                return srednia;
            }
        }
        public static int[] createarray(string name)
        {
            bool ok;
            ok = false;
            int i;
            do
            {
                try
                {
                    Console.WriteLine($"podaj ilosc elementow tablicy {name} od 0 do {int.MaxValue}");
                    i = int.Parse(Console.ReadLine());
                    int[] array = new int[i];
                    return array;
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("podaj poprawny format danych");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"podano bledny zakres liczby, podaj liczbe od 0 do {int.MaxValue}");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!ok);
            return null;
        }
    }
}