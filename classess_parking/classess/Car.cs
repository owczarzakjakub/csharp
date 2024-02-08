using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace classess_parking.classess
{
    internal class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public ushort Year { get; private set; }
        public Color Color { get; private set; }
        public void ShowInformation()
        {
            Console.WriteLine($"To jest {Brand} {Model} z {Year} o kolorze {Color}");
        }
    }
}
