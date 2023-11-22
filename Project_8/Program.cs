using System;
namespace project_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            bool IsCorrect = false;
            do
            {
                Console.WriteLine("Podaj pięć liczb całkowitych");
                try
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"Podaj liczbę całkowitą {i + 1}: ");
                        //array[i] = int.Parse(Console.ReadLine());
                        if (!int.TryParse(Console.ReadLine(), out array[i]))
                        {
                            //Console.WriteLine("error");
                            i--;
                        }

                    }
                    IsCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Nieprawidłowy format danych. Wprowadź poprawną liczbę całkowitą");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Błąd: Nieprawidłowe dane. Liczba poza zakresem < {int.MinValue} ; {int.MaxValue} >");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!IsCorrect);

            int index = 0;
            string input;
            bool IsCorrect2 = false;

            do
            {
                Console.WriteLine("\nWprowadź index lub q, aby zakonczyć program");
                input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                index = int.Parse(input);

                try
                {
                    if (index < 0)
                    {
                        throw new OverflowException("Podana liczba jest poza zakresem tablicy, podaj liczbę całkowitą większą lub równą 0");
                    }
                    if (index > array.Length - 1)
                    {
                        throw new OverflowException($"Podana liczba jest poza zakresem tablicy, podaj liczbę całkowitą mniejszą lub równą {array.Length - 1}");
                    }
                    Console.WriteLine($"Liczba pod indeksem {index} wynosi się {array[index]}");
                    IsCorrect2 = true;


                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Nieprawidłowy format danych, wprowadź liczbę całkowitą");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"Nieprawidłowe dane, Index musi być między 0 a {array.Length - 1}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Błąd: Liczba poza zakresem.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("\nDziękuje za użycie programu\n");
                }
            } while (!IsCorrect2);
            /*Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. 
             * Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. 
             * Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, 
             * program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
             * Jeśli użytkownik wprowadzi nieprawidłowe dane, 
             * program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie danych. 
             * Program powinien działać w pętli, dopóki użytkownik nie wpisze q. 
             * Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest ujemna, 
             * program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
             *Jeśli użytkownik wprowadzi nieprawidłowe dane, 
            program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby.*/
        }
    }
}