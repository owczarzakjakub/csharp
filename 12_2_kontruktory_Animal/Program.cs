using _12_2_kontruktory_Animal.classess;

namespace _12_2_kontruktory_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region animalObjects
            /*
            Animal a1 = new Animal("Burek");
            Console.WriteLine(a1.Describe());
            a1.BirthDate = new DateTime(2000, 2, 3);
            a1.ShowAge();
            */
            /*
            Animal a2 = new Animal("Mruczek", new DateTime(2020, 1, 10));
            a1.BirthDate = new DateTime(2020,1 ,10);
            Console.WriteLine(a2.Describe());
            a2.ShowAge();
            */
            /*Animal a3 = new Animal("Kootmiler", new DateTime(2020, 1, 10));
            a3.BirthDate = new DateTime(2020, 1, 10);
            Console.WriteLine(a3.Describe());
            a3.ShowAge();*/

            /*
            Animal a4 = new Animal("Mruczek", new DateTime(2020, 1, 10));
            a4.BirthDate = new DateTime(2020, 2, 3);
            Console.WriteLine(a4.Describe());
            a4.ShowAge();
            */
            #endregion

            List<Animal> animals = new List<Animal>();

            ShowMainMenu(animals);

            Console.ReadKey();
        }

        private static void ShowMainMenu(List<Animal> animals)
        {
            Console.Clear();

            Console.WriteLine("Witaj w programie do zarzadzania zwierzetami");
            Console.WriteLine("1. Dodaj zwierze");
            Console.WriteLine("2. Pokaz liste zwierzat");
            Console.WriteLine("3. Pokaz szczegoly zwierzeta");
            Console.WriteLine("4. Usun zwierze");
            Console.WriteLine("5. Zakoncz program \n");
            Console.Write("Wybierz jedna z opcji: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewAnimal(animals);
                    break;
                case "2":
                    ShowAnimaList(animals);
                    break;
                case "3":
                    ShowAnimalDetails(animals);
                    break;
                case "4":
                    RemoveAnimal(animals);
                    break;
                case "5":
                    Console.WriteLine("Dziekujemy za skorzystanie z programu");
                    return;
                deafult:
                    Console.WriteLine("niepoprawna opcja nacisnij dowolny klawisz aby sprobowac ponownie");
                    Console.ReadKey();
                    ShowMainMenu(animals);
                    break;
            }

        }

        private static void AddNewAnimal(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        private static void ShowAnimaList(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        private static void ShowAnimalDetails(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        private static void RemoveAnimal(List<Animal> animals)
        {
            throw new NotImplementedException();
        }
    }
}
