namespace project_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[4, 3];
            Console.WriteLine(ints.Rank); //2
            Console.WriteLine(ints.Length); //12
            Console.WriteLine(ints.GetLength(0)); //4
            Console.WriteLine(ints.GetLength(1)); //3
            //Console.WriteLine(ints.GetLength(2)); //idx out of range
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.WriteLine($"ints[{i}, {j}] = {ints[i, j]}");
                }
            }
            Console.WriteLine();
            int[,,] matrix = new int[4, 3, 2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine($"matrix[{i}]");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"\tmatrix[{i}, {j}]");
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        Console.Write($"\t\tmatrix[{i}, {j}, {k}]");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            int[,] cubs = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < cubs.GetLength(0); i++)
            {
                for (int j = 0; j < cubs.GetLength(1); j++)
                {
                    Console.WriteLine($"cubs[{i}, {j}] = {cubs[i, j]}");
                }
                Console.WriteLine();
            }
            double[,,] cube = new double[,,] { { { 1.3, 2.2, 3.3 } }, { { 4.1, 5.3, 6.2 } }, { { 7.2, 8.3, 9.123 } } };
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                Console.WriteLine($"cube[{i}]");
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    Console.WriteLine($"\tcube[{i}, {j}]");
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        Console.Write($"\t\tcube[{i}, {j}, {k}] = {cube[i, j, k]}");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();

        }
    }
}