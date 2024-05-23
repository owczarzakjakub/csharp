using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_14_1_dziedziczenie.classess
{
    internal class dzwig : maszyna
    {
        public dzwig(string name) : base(name)
        {
        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna podnoszenie ladunku");
        }
        //symulacja podnoszenie ladunku
        public void Lift()
        {
            Console.WriteLine($"{Name} podnosi ladunek");
        }
        public void Work()
        {
            Lift();
        }
    }
}
