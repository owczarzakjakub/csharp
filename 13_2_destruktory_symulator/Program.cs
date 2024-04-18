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
            AddCar(cars, carDictionary);
            break;
          case 2:
            DisplayCars(carDictionary);
            break;
          case 3:
                        DisplayCars(carDictionary);
                        DriveCar(carDictionary);

            
            break;
                    case 4:
                        
                        break;
                    case 5:
                        break;
                    case 6:
                        break;



        }

      }
      
      Console.ReadKey();
    }

        private static void DriveCar(Dictionary<int, Car> carDictionary)
        {
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
        static public int GetUserInput(Dictionary<int, Car> carDictionary = null)
        {
            while (true)
            {
                Console.WriteLine("Wybierz opcje: ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (carDictionary == null || carDictionary.ContainsKey (input))
                    {
                        return input;
                    }
                    else
                    {
                        Console.WriteLine("Numer samochodu nie istnieje w slowniku.");
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidlowy format danych, sproboj ponownnie");
                }
            }
        }
        private static void AddCar(List<Car> cars, Dictionary<int, Car> carDictionary)
        {
            Console.Write("Podaj markę samochodu:");
            string brand = Console.ReadLine();
            Console.Write("Podaj model samochodu:");
            string model = Console.ReadLine();
            Car newCar = new Car(brand, model);
            cars.Add(newCar);
            carDictionary[cars.Count] = newCar;
            Console.WriteLine("Dodano nowy samochód");
        }
        private static void DisplayCars(Dictionary<int, Car> carDicitionary)
        {
            if(carDicitionary.Count == 0)
            {
                Console.WriteLine("brak samochodow do wyswietlenia");
            }
            else
            {
                Console.WriteLine("\nLista samochodów:");
                foreach (var carEntry in carDicitionary)
                {
                    int key = carEntry.Key;
                    Car car = carEntry.Value;
                    Console.WriteLine($"Klucz: {key}, marka: {car}");
                }
            }
            
        }

  }
}
