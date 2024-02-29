using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor.classess
{
    internal class Person
    {
        //statyczne pole ktore przchowuje liczbe obiektow klasy person
        public static int Counter = 0;
        //wlasciwosci
        public string Name { get; set; }
        public string Surname { get; set; }
        //konstruktor statyczny jest wywolywany automatycznie aby zainicjowac klase przed utworzeniem pierwszej instancji. Konstruktor staytyczny jest wywolywany tylko raz, przed pierwszym uzyciem typu. Nie moze on miec parametru ani modyfikatorow dostepu. Sluzy do incjowania pol statycznych lub wykonywania inncyh operacji opercaji sattycznych (wykonywanie kodu ktory jest zwiazany z cala klasa a nie z jej obiektami np. ustawianie wartosci domyslnych dla pol statycznych.)
        static Person()
        {
            Console.WriteLine("Statyczny kostruktor klasy person");
            Counter++;
        }
        //konstruktor domyslny 
        /*public Person()
        {
            Console.WriteLine("kontruktor domyslny klasy person");
        }*/
        
        //konstruktor parametryczny
        public Person(string name)
        {
            Name = name;
        }

    }
}
