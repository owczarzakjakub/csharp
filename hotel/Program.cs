
/*Zadanie: System Rezerwacji Hotelowych
Cel:
Stwórz aplikację konsolową w języku C#, która symuluje prosty system rezerwacji hotelowych. Aplikacja powinna umożliwiać dodawanie pokoi, gości oraz rezerwowanie pokoi.

Wymagania:
Dodawanie pokoi:

Użytkownik powinien mieć możliwość dodania nowego pokoju do systemu.

Każdy pokój powinien mieć numer, typ (np. jednoosobowy, dwuosobowy) oraz cenę za noc.

Dodawanie gości:

Użytkownik powinien mieć możliwość dodania nowego gościa do systemu.

Każdy gość powinien mieć imię i nazwisko.

Rezerwowanie pokoi:

Użytkownik powinien mieć możliwość rezerwacji pokoju przez gościa.

Po rezerwacji pokój powinien być usunięty z listy dostępnych pokoi w hotelu.

Wyświetlanie informacji:

Użytkownik powinien mieć możliwość wyświetlenia listy wszystkich pokoi w hotelu.

Użytkownik powinien mieć możliwość wyświetlenia listy wszystkich gości w hotelu.

Użytkownik powinien mieć możliwość wyświetlenia listy wszystkich zarezerwowanych pokoi.*/

namespace hotel
{
    public class hotel
    {
        public List<guest> guests { get; set; }
        public List<room>  rooms { get; set; }

        public hotel()
        {
            guests = new List<guest>();
            rooms = new List<room>();
        }
    }
    public class room
    {
        public int number { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        public room(int number, string type, int price)
        {
            this.number = number;
            this.type = type;
            this.price = price;
        }
        public void addRoom(room Room)
        {

        }
    }
    public class guest
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public guest(string firstname, string lastanme)
        {
            firstName = firstname;
            lastName = lastanme;
        }
        public void addGuests(guest guest)
        {
            if (guests.Contains(guest))
            {
                Console.WriteLine($"Gosc {firstName} {lastName} jest juz na liscie gosci");
            }
            else
            {
                guests.Add(guest);
                Console.WriteLine($"Gosc: {firstName} {lastName} zotal dodany do listy gosci");
            } 
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
