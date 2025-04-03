namespace _6_1_pola_wlsciwosci
{

    /*enum Color
    {
        Czarny,
        Bialy,
        Czerwony
    }*/


    enum InteriorColor
    {
        Czarny,
        Bialy,
        Czerwony
    }
    class Car
    {
        //pola
        public string brand;
        public string model; //wgl nie bezpieczne pola publiczne, nie pownnismy ich tak definiowac


        //pola prywatne
        private int _productionYear;
        private decimal _price;
        private string _color;
        private string _interiorColor;

        //wlasciwosci
        public int ProductionYear
        {
            get { return _productionYear; }
            set
            {
                if (value >= 1886 && value <= DateTime.Now.Year)
                    _productionYear = value;
                else
                    throw new ArgumentException("Rok produkcj musi byc miedzy 1886 a obecnym rokiem");
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    throw new ArgumentException("Cena nie moze byc ujemna");
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                string[] allowedColor = { "czarny", "bialy", "czerwony" };
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kolor nie moze byc pusty");

                if (Array.IndexOf(allowedColor, value.ToLower()) == -1)
                {
                    string allowedColorsList = string.Join(", ", allowedColor);
                    throw new ArgumentException($"Kolor musi byc jednym z {allowedColorsList}");
                }
                _color = value;
            }
        }

        public string interiorColor
        {
            get { return _interiorColor; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kolor wnetrza nie moze byc pusty");
                if (!Enum.TryParse<InteriorColor>(value, true, out _))
                {
                    string[] allowedColorList = string.Join(", ", Enum.GetNames(typeof(InteriorColor))).ToLower();
                    
                }
            }
        }

        //kosntruktor domyslny
        public Car()
        {
            brand = "nieznana";
            model = "nieznany";
            _productionYear = 2000;
            _price = 0m;
        }

        //konstruktor parametryczny
        public Car(string brand, string model, int productionYear, decimal price, string color, string interiorColor)
        {
            this.brand = brand;
            this.model = model;
            ProductionYear = productionYear;
            Price = price;
            Color = color; 
            this.interiorColor = interiorColor;
        }

        public void DisplayCar()
        {
            Console.WriteLine($"Marka: {brand}, Model: {model}, Rok prdoukcji: {ProductionYear}, Cena: {Price:C}, Kolor: {Color}, Kolor tapicerki: {interiorColor}");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Car car1 = new Car("Toyota", "Yaris", 2024, 20M, "xd", "czarny");
                    car1.DisplayCar();
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Blad: " + e.Message);
                }
                
            }
        }
    }
}
