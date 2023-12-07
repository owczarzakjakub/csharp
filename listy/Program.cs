namespace listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(-1);
            ints.Add(100);
            Console.WriteLine("Długośc listy: {0}", ints.Count);
            ints.Add(1);
            Console.WriteLine("Długość listy: {0}", ints.Count);
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            ints.Remove(1);

            foreach(int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            ints.Remove(1);
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();*/

            List<int> ints = new List<int>();
            for (int i = 0; i <= 50; i++)
            {
                Random losuj = new Random();
                ints.Add(losuj.Next(1, 101));
            }
            Console.WriteLine("ELEMENTY LISTY: ");
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\npodzielne kotomiler: ");
            List<int> kotomilery35 = podzielnosc(ints);
            foreach(int kotomiler in kotomilery35)
            {
                Console.Write($"{kotomiler} ");
            }

        }
        public static List<int> podzielnosc(List<int> lista)
        {

            List<int> kotomiler = new List<int>();

            for (int i = 0; i <= 50; i++)
            {
                if(lista[i]%3==0 || lista[i]%5 == 0)
                {
                    kotomiler.Add(i);
                }
            }


            return kotomiler;
        }
    }
}
