using System;

namespace project1_dziedzicenie
{
    class Program
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
            rectangle rect = new rectangle();

            rect.setHeight(2.5f);
            rect.setWidth(3f);

            Console.WriteLine("Pole prostokatat wynosi: " + rect.CalculateArea());

            Circle circ = new Circle();
            circ.setRadius(2.4f);
            Console.WriteLine("pole kola wynosi: " + circ.CalculateArea());

            Console.ReadKey();
        }
    }
}
