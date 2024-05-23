using project_14_1_dziedziczenie.classess;

namespace project_14_1_dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            maszyna machine = new maszyna("R-100");
            koparka excavator = new koparka("E-200");
            excavator.Start();
            excavator.Stop("Awaria silnika");
            excavator.Work();
            //excavator.Dig();
            Console.ReadKey();
        }
    }
}
