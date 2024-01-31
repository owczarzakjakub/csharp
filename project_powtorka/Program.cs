using System.Collections.Specialized;
using System.Diagnostics.Metrics;

namespace project_powtorka_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> kraje = new List<string>() { "Polska", "Rosja", "Niemcy" };
            List<string> stolice = new List<string>() { "Warszawa", "Moskwa", "Berlin" };
            List<int> list = CreateList(4);
            FillList(list);
            PrintList(list);
            int[,] multiarray = CreateMultiDimensionalarray(2);
            fillarray(multiarray);
            int it;
            Console.WriteLine("Tablica: ");
            for (int i = 0; i < multiarray.GetLength(0); i++)
            {
                it = 0;
                Console.WriteLine();
                for (int j = 0; j < multiarray.GetLength(1); j++)
                {
                    it++;
                    if(it < 2)
                    {
                        Console.Write(multiarray[i, j] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(multiarray[i, j]);
                    }
                    
                }
            }
            SumaPrzekatnej(multiarray);
            Dictionary<string, string> krajestolice = CreateDictionary(kraje, stolice);
            last(krajestolice);
        }



        public static List<int> CreateList(int dlugosc)
        {
            try
            {
                if (dlugosc <= 0)
                {
                    throw new ArgumentException("Dlugosc listy musi byc dodatnia");
                }
                return new List<int>(new int[dlugosc]);
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine("Błąd: " + ex.Message);
                return new List<int>();
            }
        }


        public static void FillList (List<int> list)
        {
            Random losowa = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                list[i] =  losowa.Next(1, 101);
            }
        }


        public static void PrintList (List<int> list)
        {
            Console.WriteLine("Lista wypelniona liczbami calkowitym od 1 do 100: " + string.Join(", ", list));
        }


        public static int[,] CreateMultiDimensionalarray(int dlugosc)
        {
            int[,] array = new int[dlugosc, dlugosc];
            return array;
        }


        public static void fillarray(int[,] array)
        {
            Random losowa = new Random();
            for(int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = losowa.Next(1, 100);
                }
            }
        }


        public static void SumaPrzekatnej(int[,] array)
        {
            int suma = 0;
            for (int i = 0; i < array.GetLength(0) ; i++)
            {
                suma = suma + array[i, i];
            }
            Console.WriteLine("Suma przkatnej wynosi: " + suma);
        }

        public static Dictionary<string, string> CreateDictionary(List<string> stolice, List<string> kraje)
        {
            Dictionary<string, string> krajestolice = new Dictionary<string, string>();
            for(int i = 0; i < stolice.Count; i++)
            {
                krajestolice.Add(stolice[i], kraje[i]);
            }
            return krajestolice;
        }
        public static void last(Dictionary<string, string> slownik)    
        {
            bool valid = false;
            do
            {
                try
                {
                    Console.Write("Podaj nazwe kraju lub \"q\" aby zakonczyc program : ");
                    string c = Console.ReadLine();
                    if (c == "q")
                    {
                        break;
                    }
                    {
                        
                    }
                    Console.WriteLine("Stolica tego kraju to: " + slownik[c]);
                    valid = true;
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Bark tego panstwa w bazie danych");
                }
                catch (Exception)
                {
                    Console.WriteLine("BŁĄD");
                }
            } while(!valid);
            
            

        }
    }
}