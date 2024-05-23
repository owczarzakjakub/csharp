using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_14_1_dziedziczenie.classess
{
    internal class buldozer : maszyna
    {
        public buldozer(string name) : base(name)
        {
        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna rownac teren");
        }
        //symulacja rownania terenu
        public void Flatten()
        {
            Console.WriteLine($"{Name} zaczyna rownac teren");
        }
        public void Work()
        {
            Flatten();
        }
    }
}
