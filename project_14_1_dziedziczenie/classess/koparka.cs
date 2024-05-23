using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_14_1_dziedziczenie.classess
{
    internal class koparka : maszyna
    {
        public koparka(string name) : base(name)
        {

        }
        //przesloniecie metody wirtualnej
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"Koparka {Name} rozpoczyna kopanie");
        }
        //przeciazenie metody stop
        public void Stop(string Reason)
        {
            Console.WriteLine($"Koparka {Name} zostala zatrzymana z powodu: {Reason}");
        }
        //symulacja kopania
        public void Dig()
        {
            Console.WriteLine($"Koparka {Name} kopie");
        }
        //przesloniecie metody work
        public override void Work()
        {
            Dig();
        }
    }
}
