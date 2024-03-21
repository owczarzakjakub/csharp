using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kartkowka_konstruktory_JO.classess;

namespace kartkowka_konstrukotry_JO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Samochod> samochody = new List<Samochod>();
            samochody.Add(new Samochod());
            samochody.Add(new Samochod("mazda", "miata mx5", 1999, 3.0, false, new DateTime(2001, 1, 1), StatusSamochodu.Uzywany));

            for (int i = 0; i < samochody.Count; i++)
            {
                samochody[i].WyswietlInformacje();
                samochody[i].ObliczWiekSamochodu();

            }
        }
    }
}
