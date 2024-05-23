using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_14_1_dziedziczenie.classess
{
    internal class maszyna
    {
        public string Name { get; set; }
        public maszyna(string name)
        {
            Name = name;
        }
        public virtual void Start()
        {
            Console.WriteLine("Maszyna " + Name + " zostala wlaczona");
            
        }
        public virtual void Stop()
        {
            Console.WriteLine($"Maszyna {Name} zostala wylaczona");
        }
        //symulacja pracy maszyny
        public virtual void Work()
        {
            Console.WriteLine($"Maszyna {Name} pracuje");
        }

    }
}
