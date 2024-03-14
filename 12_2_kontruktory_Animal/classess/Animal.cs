using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_kontruktory_Animal.classess
{
    enum Kind
    {
        Ptak,
        Ryba,
        Gad,
        Płaz,
        Ssak
    }
    internal class Animal
    {
        //WLASCIWOSCI
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMammal { get; set; }
        public Kind Kind { get; set; }
        //KONSTRUKTORY
        public Animal(string name)
        {
            Name = name;
        }
        public Animal (string name, DateTime birthDate): this(name)
        {
                BirthDate = birthDate;
        }
        public Animal (string name, DateTime birthDate, bool isMammal): this(name, birthDate)
        {
            IsMammal = isMammal;
        }
        public Animal(string name, DateTime birthDate, bool isMammal, Kind kind): this(name, birthDate, isMammal)
        {
            Kind = kind;
        }
        //METODY
        public string Describe()
        {
            string description = "Nazwa zwierzecia" + Name + "Data urodzenia" + BirthDate.ToShortDateString() + "r. ";
            if (IsMammal)
            {
                description += "\n Zwierze jest ssakiem.";
            }
            else
            {
                description += "\n Zwierze nie jest ssakiem";
            }

            description += "Rodzaj ziwerzecia: " + Kind;

            return description;
        }
        public void ShowAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            Console.WriteLine($"Wiek {Name} wynosi: {age}");

        }
    }
   
}
