using _13_2_destruktor_symulator.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_destruktor_symulator
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Car> cars = new List<Car>();
      Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

      while (true)
      {
        DisplayMenu();

        int choice = GetUserInput();

        switch(choice)
        {
          case 1:
            Console.Write("Podaj markę samochodu:");
            string brand = Console.ReadLine();
            Console.Write("Podaj model samochodu:");
            string model = Console.ReadLine();
            Car newCar = new Car(brand, model);
            cars.Add(newCar);
            carDictionary[cars.Count] = newCar;
            Console.WriteLine("Dodano nowy samochód");
            break;
          case 2:
            Console.WriteLine("\nLista samochodów:");
            foreach (Car car in cars)
            {
              Console.WriteLine($"{car.Brand} {car.Model}");
            }
            break;
          case 3:
            Console.Write("Podaj numer samochodu do jazdy:");
            int carNumber = int.Parse(Console.ReadLine());
            if (carDictionary.TryGetValue(carNumber, out Car selectedCar))
            {
              selectedCar.Drive();
            }
            else
            {
              Console.WriteLine("Nierawidłowy numer samochodu");
            }
            break;
                    case 4:
                        Console.WriteLine("\nPodaj numer samochodu do symulacji uszkodzen");
                        int damagedCraNumber
                        break;
                    case 5:
                        break;
                    case 6:
                        break;



        }

      }
      
      Console.ReadKey();
    }
        static public void DisplayMenu()
        {
            Console.WriteLine("Menu symulatora jazdy samochodem");
            Console.WriteLine("1. Dodaj samochód");
            Console.WriteLine("2. Wyświetl listę samochodów");
            Console.WriteLine("3. Jedź samochodem");
            Console.WriteLine("4. Symuluj losowe uszkodzenie");
            Console.WriteLine("5. Zezłomuj samochód");
            Console.WriteLine("6. Wyjście");
        }
        static public int GetUserInput()
        {
            while (true)
            {
                Console.WriteLine("Wybierz opcje: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Blednie wprowadzoen dane, sproboj ponownnie");
                }
            }
        }
  }
}
