using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_parking.classess
{
    internal class Parking
    {
        public string name { get; set; }
        public Car[] Cars { get; set; }

        public void AddCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] == null)
                {
                    Cars[i] = car;
                    Console.WriteLine("Dodano samochód na miejscu na miejscu parkingowym numer: {0}", i);
                    return;
                }
                Console.WriteLine("Brak wolnych miejsc parkingowych.");
            }
        }
        public void RemoveCar(int index)
        {
            if (index >= 0 && index < Cars.Length)
            {
                if (Cars[index] != null)
                {
                    Cars[index] = null;
                    Console.WriteLine("Samochod został usuniety z danego miejsca parkingowego o numerze {0}", index);
                }
                else
                {
                    Console.WriteLine("W podanym miejscu parkingowym nie ma samochodu");
                }
            }
            else
            {
                Console.WriteLine("Błędnu numer miejsca postojowego an parkingu");
            }
        }
        public void ShowCars()
        {
            Console.WriteLine($"Parking {name} ma {Cars.Length} miejsc parkingowych");
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] != null)
                {
                    Console.WriteLine($"Miejsce parkingowe numer {i + 1}: ");
                    Cars[i].ShowInformation();
                }
                else
                {
                    Console.WriteLine($"Wolne miejsce numer: {i + 1}");
                }
            }
        }
    }
}
