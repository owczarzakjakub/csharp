using System.Security.AccessControl;

namespace project_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("podaj bok a:");
            double a;
            a = double.Parse(Console.ReadLine());
            */
            /*
            Console.WriteLine("PODAJ BOK A");
            double a;
            double.TryParse(Console.ReadLine(), out a);
            */

            /*
            Console.WriteLine("PODAJ BOK A");
            double a;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(a);
            }
            */
            /*
            int k;
            k = 1;

            while (k == 1)
            {

                double a;
                Console.Write("podaj a: ");
                while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.Write("podaj bok a poprawnie: ");
                }
                Console.WriteLine($"bok a wynosi: {a}");


                double b;
                Console.Write("podaj b: ");
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.Write("podaj bok a poprawnie: ");
                }
                Console.WriteLine($"bok b wynosi: {b}");


                double c;
                Console.Write("podaj c: ");
                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.Write("podaj bok a poprawnie: ");
                }
                Console.WriteLine($"bok c wynosi: {c}");



                if ((IsTriangle(a, b, c)))
                {
                    double p;
                    p = (a + b + c) / 2;
                    p = Math.Sqrt(p * (p - a) * (p - c) * (p - b));
                    Console.WriteLine($"pole {a}");
                    k = 0;
                }
                else
                {
                    k = 1;
                }
            }
        }
        */

            bool IsCorrect;
            IsCorrect = false;
            do
            {
                double a;
                Console.Write("podaj a: ");
                while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.Write("podaj bok a poprawnie: ");
                }
                Console.WriteLine($"bok a wynosi: {a}");


                double b;
                Console.Write("podaj b: ");
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.Write("podaj bok a poprawnie: ");
                }
                Console.WriteLine($"bok b wynosi: {b}");


                double c;
                Console.Write("podaj c: ");
                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.Write("podaj bok a poprawnie: ");
                }
                Console.WriteLine($"bok c wynosi: {c}");


                if ((IsTriangle(a, b, c)))
                {
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.WriteLine($"pole trojkata wynosi: {AreaTriangle(a, b, c):F4}cm²" ); //² <= to mozna inaczej zapisac jako \u00B2
                    IsCorrect = true;
                    Console.OutputEncoding = System.Text.Encoding.Default;
                }
                else
                {
                    IsCorrect = false;
                    Console.WriteLine("z podanch bokow nie mozna utworzyc trojkatow");
                    Thread.Sleep(3000);
                    Console.Clear();
                }

            } while (!IsCorrect);

            static bool IsTriangle(double a, double b, double c)
            {
                return a + b > c && a + c > b && b + c > a;
            }
            static double AreaTriangle(double a, double b, double c)
            {
                double p;
                p = (a + b + c) / 2;
                p = Math.Sqrt(p * (p - a) * (p - c) * (p - b));
                return p;
            }
        }
    }
}