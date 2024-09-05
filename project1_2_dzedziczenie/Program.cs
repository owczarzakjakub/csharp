namespace project1_2_dzedziczenie
{
    internal class Program
    {
        class shape
        {

            public virtual float CalculateArea()
            {
                return 0;
            }
            public virtual float CalculatePerimeter()
            {
                return 0;
            }
        }
        class rectangle : shape
        {
            private float width;
            private float height;

            public void setDimensions(float w, float h)
            {
                width = w;
                height = h;
            }
            public override float CalculateArea()
            {
                return width * height;
            }
        }
        class Circle : shape
        {
            private float radius;
            public Circle(float r)
            {
                radius = r;
            }
            public void setRadius(float r)
            {
                radius = r;
            }

            public override float CalculateArea()
            {
                //return base.CalculateArea();
                return (float)Math.PI * radius * radius;
            }

        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("wybierz ksztalt do obliczenia: ");
                Console.WriteLine("1. Prostokąt");
                Console.WriteLine("2. Koło");
                Console.WriteLine("3. Trojkat");
                Console.WriteLine("4. Trapez");
                Console.WriteLine("5. Kula");
                Console.WriteLine("6. Wyjscie");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        rectangle rect  = new rectangle();
                        Console.WriteLine("podaj szerokosc: ");
                        float rectWidth = float.Parse(Console.ReadLine());
                        Console.WriteLine("podaj wysokosc: ");
                        float rectheight = float.Parse(Console.ReadLine());
                        rect.setDimensions(rectWidth, rectheight);
                        Console.WriteLine("powierzchnia prostokata: " + rect.CalculateArea());;
                        Console.WriteLine("obwod prostokata: " + rect.CalculatePerimeter());
                        break;
                    case 2:
                        float circleRadius = GetValidInput("Podaj promien: ");
                        Circle circ  = new Circle(circleRadius);
                        Console.WriteLine("Powierzchnia kola: " + circ.CalculateArea());
                        Console.WriteLine("Obwod kola: " + "*dodac w domu*");
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Nieprawidlowy wybor, sproboj ponownie");
                        break;
                    
                }
            }

            /*rectangle rect = new rectangle();

            rect.setHeight(2.5f);
            rect.setWidth(3f);

            Console.WriteLine("Pole prostokatat wynosi: " + rect.CalculateArea());

            Circle circ = new Circle();
            circ.setRadius(2.4f);
            Console.WriteLine("pole kola wynosi: " + circ.CalculateArea());

            Console.ReadKey();
            */
        }

        private static float GetValidInput(string prompt)
        {
            float result;
            while (true)
            {
                Console.Write(prompt);
                if(float.TryParse(Console.ReadLine(), out result) && result > 0)
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nieprawislowe dane, sprobuj ponownie.");
                    Console.ResetColor();
                }
            }
            return 0;
        }
    }
}
