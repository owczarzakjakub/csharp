using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4_delegaty
{
    internal class Program
    {
        public delegate float Operation(float x, float y);

        public static float Add(float x, float y)
        {
            return (x + y);
        }

        public static float Substract(float x, float y)
        {
            return (x - y);
        }

        public static float Multity(float x, float y)
        {
            return x * y;
        }

        public static float Divide(float x, float y)
        {
            return x / y;
        }

        public static void displayResult(Operation op, float x, float y)
        {
            float result;
            if (op.Method.Name == "Divide" && y == 0)
            {
                Console.WriteLine("Bledne dzielenie przez 0");
            }
            else
            {
                try
                {
                    result = op(x, y);
                    Console.WriteLine("Wynik operacji {0} na liczbach {1} i {2} wynosi: {3}", op.Method.Name, x, y, result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    result = 0;
                }
            }
        }

        public static float GetFloatFromUser(string prompt)
        {
            Console.WriteLine(prompt);
            float number;

            bool isValid = float.TryParse(Console.ReadLine(), out number);


            while (!isValid)
            {
                Console.WriteLine("Nieprawidlowe dane. Podaj liczbe: ");
                isValid = float.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        static void Main(string[] args)
        {
            float a = GetFloatFromUser("Podaj pierwsza liczbe: ");
            float b = GetFloatFromUser("Podaj druga liczbe: ");

            Operation adding = new Operation(Add);
            Operation substracting = new Operation(Substract);
            Operation multiplying = new Operation(Multity);
            Operation dividing = new Operation(Divide);

            displayResult(adding, a, b);
            displayResult(substracting, a, b);
            displayResult(multiplying, a, b);
            displayResult(dividing, a, b);

            Console.ReadKey();
        }
    }
}
