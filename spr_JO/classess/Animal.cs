using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace spr_JO.classess
{
    internal class Animal
    {
        enum Species
        {
            Pies,
            Kot,
            Królik
        }
        public enum HealthStatus
        {
            Zdrowy,
            Chory,
            Ranny
        }
        public string Name { get; set; }
        public HealthStatus healthStatus { get; set; }
        Animal()
        {
            healthStatus = HealthStatus.Zdrowy;
        }
        public Animal(string name, HealthStatus status)
        {
            Name = name;
            healthStatus = status;
        }
        ~Animal()
        {
            Console.WriteLine("Zwierze zostalo usuniete z pamieci");
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("1. Dodaj zwierze");
            Console.WriteLine("2. Wyswietl liste zwierzat");
            Console.WriteLine("3. Ulecz zwierze");
            Console.WriteLine("4. Zachoruj zwierze");
            Console.WriteLine("5. Zaadoptuj zwierze");
            Console.WriteLine("6. Zakoncz dzialanie programu");
        }
        public static void AddAnimal(List<Animal> animals, Dictionary<int, Animal> animalsDictionary)
        {
            Console.WriteLine("podaj imie zwierzecia");
            string animalName = Console.ReadLine();
            Animal animal = new Animal(animalName, HealthStatus.Zdrowy);
            animals.Add(animal);
            animalsDictionary[animals.Count()] = animal;
        }
        public static void DisplayAnimals(List<Animal> animals)
        {
            Console.WriteLine("Lista zwierzat: ");
            if (animals.Count() > 0)
            {
                foreach (Animal animal in animals)
                {
                    Console.WriteLine($"{animal.Name}, {animal.healthStatus}");
                }
            }
        }
        public static void HealAnimal(Dictionary<int, Animal> animalsDictionary)
        {
            Console.WriteLine("Podaj numer zwierzecia: ");
            int usersHealedAnimal = int.Parse(Console.ReadLine());
            if(animalsDictionary.TryGetValue(usersHealedAnimal, out Animal healedAnimal))
            {
                healedAnimal.healthStatus = HealthStatus.Zdrowy;
            }
            else
            {
                Console.WriteLine("Takie zwierze nie istnieje");
            }
        }
        public static void GetSick(Dictionary<int, Animal> animalsDictionary)
        {
            Console.WriteLine("Podaj numer zwierzecia: ");
            int usersSickAnimal = int.Parse(Console.ReadLine());
            if (animalsDictionary.TryGetValue(usersSickAnimal, out Animal sickAnimal))
            {
                sickAnimal.healthStatus = HealthStatus.Chory;
            }
            else
            {
                Console.WriteLine("Takie zwierze nie istnieje");
            }
        }
        public static void AdoptAnimal(Dictionary<int, Animal> animalsDictionary)
        {
            Console.WriteLine("Podaj numer zwierzecia: ");
            int usersAdoptedAnimal = int.Parse(Console.ReadLine());
            if (animalsDictionary.TryGetValue(usersAdoptedAnimal, out Animal adoptedAnimal))
            {
                Console.WriteLine($"Zwierze {adoptedAnimal.Name} zostalo adoptowane!");
            }
            else
            {
                Console.WriteLine("Takie zwierze nie istnieje");
            }
        }
        public static int GetUsersInput()
        {
            Console.WriteLine("Wybierz dzialanie z menu: ");
            int usersInt = int.Parse(Console.ReadLine());
            return usersInt;
        }
    }
    
   
}
