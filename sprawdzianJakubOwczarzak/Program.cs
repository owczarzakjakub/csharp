using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzianJakubOwczarzak
{

    internal class Program
    {
        public interface IAnimal
        {
            void MakeSound();
            void Eat();
        }
        public abstract class Animal : IAnimal
        {
            public string Name { get; set; }
            public string Species { get; set; }
            public int Age { get; set; }
            public string Owner { get; set; }
            public Animal(string name, string species, int age, string owner)
            {
                Name = name;
                Species = species;
                Age = age;
                Owner = owner;
            }
            public void Eat()
            {
                Console.WriteLine($"{Name} je");
            }
            public abstract void MakeSound();
            public string displayAnimal()
            {
                return $"{Name}, {Species}, {Age}, {Owner}";
            }

        }
        public class Cat : Animal
        {
            public Cat(string name, string species, int age, string owner) : base(name, species, age, owner) { }
            public override void MakeSound()
            {
                Console.WriteLine("Miau!");
            }
        }
        public class Dog : Animal
        {
            public Dog(string name, string species, int age, string owner) : base(name, species, age, owner) { }
            public override void MakeSound()
            {
                Console.WriteLine("Hau!");
            }
        }
        
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Azor", "Pies", 2, "Jan Kowlaski");
            Cat cat1 = new Cat("Filemon", "Kot", 3, "Anna Nowak");

            dog1.MakeSound();
            dog1.Eat();
            cat1.MakeSound();
            cat1.Eat();

            Console.WriteLine();

            List<Animal> animals = new List<Animal>();

            animals.Add(dog1);
            animals.Add(cat1);
            animals.Add(new Dog("Reksio", "Pies", 4, "Piotr Wisniewski"));
            animals.Add(new Cat("Mruczek", "Kot", 1, "Katarzyna Zielinska"));

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
                animal.Eat();
            }

            Console.WriteLine("\nSortowanie po wg. wlasciciela w porzadku alfabetycznym: ");
            animals.Sort((animal, otherAnimal) => animal.Owner.CompareTo(otherAnimal.Owner));
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.displayAnimal());
            }

            Console.WriteLine("\nSortowanie wg. gatunku: ");
            animals.Sort((animal, otherAnimal) => animal.Species.CompareTo(otherAnimal.Species));
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.displayAnimal());
            }

            Console.WriteLine("\nSortowanie wg. wieku: ");
            animals.Sort((animal, otherAnimal) => animal.Age.CompareTo(otherAnimal.Age));
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.displayAnimal());
            }

            Console.WriteLine("\nSortowanie wg. imienia: ");
            animals.Sort((animal, otherAnimal) => animal.Name.CompareTo(otherAnimal.Name));
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.displayAnimal());
            }

            bool isValid = true;
            while (isValid)
            {
                Console.WriteLine("\n1.Sortowanie wg. wlasciciela\n2.Sortowanie wg. gatunku\n3.Sortowanie wg. wieku\n4.Sortowanie wg. imienia\n5.Wyjscie");
                Console.Write("Wybierz opcje: ");
                string input = Console.ReadLine();
                int choice;
                while (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("\nBlad! Wybierz ponownie");
                    Console.WriteLine("\n1.Sortowanie wg. wlasciciela\n2.Sortowanie wg. gatunku\n3.Sortowanie wg. wieku\n4.Sortowanie wg. imienia\n5.Wyjscie\n");
                    Console.WriteLine("Wybierz opcje: ");
                    input = Console.ReadLine();

                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nSortowanie po wg. wlasciciela w porzadku alfabetycznym: ");
                        animals.Sort((animal, otherAnimal) => animal.Owner.CompareTo(otherAnimal.Owner));
                        foreach (Animal animal in animals)
                        {
                            Console.WriteLine(animal.displayAnimal());
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nSortowanie wg. gatunku: ");
                        animals.Sort((animal, otherAnimal) => animal.Species.CompareTo(otherAnimal.Species));
                        foreach (Animal animal in animals)
                        {
                            Console.WriteLine(animal.displayAnimal());
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nSortowanie wg. wieku: ");
                        animals.Sort((animal, otherAnimal) => animal.Age.CompareTo(otherAnimal.Age));
                        foreach (Animal animal in animals)
                        {
                            Console.WriteLine(animal.displayAnimal());
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nSortowanie wg. imienia: ");
                        animals.Sort((animal, otherAnimal) => animal.Name.CompareTo(otherAnimal.Name));
                        foreach (Animal animal in animals)
                        {
                            Console.WriteLine(animal.displayAnimal());
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nDziekujemy za skorzystanie z programu.");
                        isValid = false;
                        break;
                }
                
            }

            Console.ReadKey();
        }
    }
}
