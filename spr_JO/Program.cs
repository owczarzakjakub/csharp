using spr_JO.classess;

namespace spr_JO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Dictionary<int, Animal> animalsDictionary = new Dictionary<int, Animal>();  
            while (true)
            {
                Animal.DisplayMenu();
                int usersChoice = Animal.GetUsersInput();
                switch (usersChoice)
                {
                    case 1:
                        Animal.AddAnimal(animals, animalsDictionary);
                        break;
                    case 2:
                        Animal.DisplayAnimals(animals);
                        break;
                    case 3:
                        Animal.HealAnimal(animalsDictionary);
                        break;
                    case 4:
                        Animal.GetSick(animalsDictionary);
                        break;
                    case 5:
                        Animal.AdoptAnimal(animalsDictionary);
                        break;
                    case 6:
                        return;
                        break;
                    deafult:
                        break;
                }
            }
        }
    }
}
