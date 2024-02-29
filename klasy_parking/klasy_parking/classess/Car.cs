using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace klasy_parking.classess
{
    enum Color
    {
        czerwony,
        zielony,
        niebieski
    }
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public ushort Year { get; set; }
        public Color Color { get; set; }
        public void ShowInformation()
        {
            Console.WriteLine($"To jest {Brand} {Model} z {Year} o kolorze {Color}");
        }
    }
}
