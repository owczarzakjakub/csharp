using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public interface ICar
    {
        void startEngine();
        void Drive();
    }
    public abstract class Car : ICar
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Owner { get; set; }
        public Car(string brand, string model, int year, string owner)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Owner = owner;
        }



        public void startEngine()
        {
            Console.WriteLine("{0} {1} uruchamia silnik", Brand, Model);
        }
        public abstract void Drive();
        public string toString()
        {
            return($"{Brand}, {Model}, {Owner}, {Year}");
        }
    }

    public class ElectricCar : Car
    {
        public ElectricCar(string brand, string model, int year, string owner) : base(brand, model, year, owner) { }
        public override void Drive()
        {
            Console.WriteLine("Jazda na elektrycznosci");
        }
    }
    public class GasolineCar : Car
    {
        public GasolineCar(string brand, string model, int year, string owner) : base(brand, model, year, owner) { }
        public override void Drive()
        {
            Console.WriteLine("Jazda na benzynie");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricCar ecar = new ElectricCar("Tesla", "S", 2022, "Janusz Kowalski");
            GasolineCar gascar = new GasolineCar("Syrenka", "105", 1970, "Janusz Kowalski");

            ecar.startEngine();
            ecar.Drive();
            gascar.startEngine();
            gascar.Drive();

            Console.WriteLine("----------------------------------------------");

            List<Car> carList = new List<Car>();

            carList.Add(ecar);
            carList.Add(gascar);
            carList.Add(new GasolineCar("Ford", "Mustang", 2018, "Anna Nowak"));
            carList.Add(new ElectricCar("Nissan", "Leaf", 2019, "Piotr Wiśniewski"));
            carList.Add(new GasolineCar("BMW", "X5", 2017, "Katarzyna Zielińska"));

            foreach (Car car in carList)
            {
                car.startEngine();
                car.Drive();
            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Sorotowanie po autorze: ");
            carList.Sort((a, b) => a.Owner.CompareTo(b.Owner));
            foreach (Car car in carList)
            {
                Console.WriteLine(car.toString());
            }

            Console.WriteLine("---------------------------------------------");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n1.Sortuj po wlascicielu\n2.Sortuj po roku produkcji w porzadku rosnacym\n3.Sortuj po marce\n4.Sortuj po modelu\n5. Zakoncz program");
                Console.Write("Wybierz sortowanie: ");
                string input = Console.ReadLine();
                int number;
                while (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Bledne dane");
                    Console.WriteLine("\n1.Sortuj po wlascicielu\n2.Sortuj po roku produkcji w porzadku rosnacym\n3.Sortuj po marce\n4.Sortuj po modelu\n5.Zakoncz program");
                    Console.Write("Wybierz sortowanie: ");
                    input = Console.ReadLine();


                }

                switch (number)
                {
                    case 1:
                        Console.WriteLine("\nSortowanie po wlascicielu:");
                        carList.Sort((a, b) => a.Owner.CompareTo(b.Owner));
                        foreach (Car car in carList)
                        {
                            Console.WriteLine(car.toString());
                        }

                        break;
                    case 2:
                        Console.WriteLine("\nSortowanie po roku produkcji w porzadku rosnacym: ");
                        carList.Sort((a, b) => a.Year.CompareTo(b.Year));
                        foreach (Car car in carList)
                        {
                            Console.WriteLine(car.toString());
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nSortowanie po marce: ");
                        carList.Sort((a, b) => a.Brand.CompareTo(b.Brand));
                        foreach (Car car in carList)
                        {
                            Console.WriteLine(car.toString());
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nSortowanie wedlug modelu: ");
                        carList.Sort((car, otherCar) => car.Model.CompareTo(otherCar.Model));
                        foreach(Car car in carList)
                        {
                            Console.WriteLine(car.toString());
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nDziekujemy za skorzystanei z programu!");
                        running = false;
                        break;
                }
                

            }

            Console.ReadKey();
        }
    }
}
