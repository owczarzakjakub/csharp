using System.Diagnostics;

namespace project_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MinValue); //-2,147,483,648
            Console.WriteLine(int.MaxValue); //2147483647

            Console.WriteLine(char.MaxValue); //?

            string firstName = "Janusz";
            Console.WriteLine(firstName.Length);


            Console.WriteLine(firstName[0]);

            string lastName = "Nowak";
            Console.WriteLine(firstName.Equals(lastName)); //false
            Console.WriteLine("Janusz".Equals("janusz")); //false 
            Console.WriteLine("Janusz".Equals("Janusz")); //true


            //#####################################################

            Console.Write("podaj imie: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"imie: {name}");

            Console.WriteLine("####################################");


            while (name.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("podaj imie: ");
                name = Console.ReadLine();
            }
            Console.WriteLine($"imie: {name}");

            
            Thread.Sleep(2000);


            float a;
            /*do
            {
                Console.Clear();
                Console.WriteLine("podaj bok a: ");
                a = Console.Read();
            } while (a <= 0);
            Console.WriteLine($"pole kwadratu o boku: {a} wynosi: {a*a}");    !!!!!!!!!!!!!!!!TO JEST BLEDNE
            */



            do
            {
                Console.Clear();
                Console.WriteLine("podaj bok a: ");
                a = float.Parse(Console.ReadLine());
            } while (a <= 0);
            Console.WriteLine($"pole kwadratu o boku: {a} wynosi: {a * a:F2}"); //POPRAWNA WERSJA (F2 sluzy do ograniczrnia liczby do dwoch miejsc po przecinku)

            //####################################
            //WZOR HERONA
            float b, c, d;
            do
            {
                Console.Clear();
                Console.WriteLine("podaj boki b,d,c: ");
                b = float.Parse(Console.ReadLine());
                c = float.Parse(Console.ReadLine());
                d = float.Parse(Console.ReadLine());
            } while (b+c<d || b+d<c || c+d<b);
            Console.WriteLine("git");
            float p = (a + b + c) / 2;


        }
    }
}