using klasy_parking.classess;

namespace klasy_parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Brand = "Fiat",
                Model = "126p",
                Year = 1980,
                Color = Color.czerwony

            };
            Car car2 = new Car
            {
                Brand = "Ferrari",
                Model = "F430",
                Year = 2023,
                Color = Color.czerwony

            };
            Car car3 = new Car
            {
                Brand = "Audi",
                Model = "RS3",
                Year = 2024,
                Color = Color.niebieski

            };

            Parking parking1 = new Parking { name = "center", Cars = new Car[5] };

            parking1.AddCar(car1);
            parking1.AddCar(car2);
            parking1.ShowCars();
            parking1.RemoveCar(0);
            parking1.ShowCars();

        }
    }
}
