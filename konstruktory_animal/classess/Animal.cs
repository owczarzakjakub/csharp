using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktory_animal.classess
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
        //WŁAŚCIWOŚCI
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMammal { get; set; }
        public Kind Kind { get; set; }
        //KONSTRUKTORY--------------------------------------------------------------------------
        public Animal(string name)
        {
            Name = name;
        }
        public Animal(string name, DateTime birthDate) : this(name)
        {
            BirthDate = birthDate;
        }
        public Animal(string name, DateTime birthDate, bool isMammal) : this(name, birthDate)
        {
            IsMammal = isMammal;
        }
        public Animal(string name, DateTime birthDate, bool isMammal, Kind kind) : this(name, birthDate, isMammal)
        {
            Kind = kind;
        }
        //METODY
        public string Describe()
        {
            string description = "Nazwa zwierzęcia: " + Name + ",\nData urodzenia: " + BirthDate.ToShortDateString() + "r., ";
            if (IsMammal)
            {
                description += "\nZwierze jest ssakiem,";
            }
            else
            {
                description += "\nZwierze nie jest ssakiem,";
            }
            description += "\nRodzaj zwierzęcia: " + Kind;

            return description;
        }
        public void ShowAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            Console.WriteLine($"Wiek {Name} wynosi {age}");
        }
        
    }
}
