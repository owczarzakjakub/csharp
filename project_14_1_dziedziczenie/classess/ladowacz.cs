using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace project_14_1_dziedziczenie.classess
{
    internal class ladowacz : maszyna
    {
        public ladowacz(string name) : base(name)
        {
        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} zaczyna ladowanie materialu");
        }
        public void Load()
        {
            Console.WriteLine($"{Name} laduje material");
        }
        public void Work()
        {
            Load();
        }
    }
}
