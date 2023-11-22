using System;

namespace project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            bool IsCorrect = false;
            do
            {
                Console.WriteLine("Podaj dwie liczby");
                try
                {
                    Console.Write("Podaj x: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Podaj y: ");
                    y = int.Parse(Console.ReadLine());
                    if (y != 0)
                    {
                        Console.Write("Iloraz zmiennej ");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine($"{x} / {y} = {x / y}");
                    Console.ResetColor();
                    IsCorrect = true;
                }
                catch (FormatException)
                {
                    ErrorColor("Podaj liczbę całkowitą");
                }
                catch (OverflowException)
                {
                    ErrorColor($"Liczba poza zakresem <{int.MinValue} ; {int.MaxValue}>");
                }
                catch (DivideByZeroException)
                {
                    ErrorColor("Dzielenie przez 0");
                }

                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    Console.WriteLine($"Błąd: {ex.Message}");

                }
                finally
                {
                    Console.WriteLine("Dziękujemy za skorzystanie z programu\n");
                }
            } while (IsCorrect == false);

            Console.ReadKey();
        }

        static void ErrorColor(string x)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Błąd: {x}");
            Console.ResetColor();
        }
    }
}