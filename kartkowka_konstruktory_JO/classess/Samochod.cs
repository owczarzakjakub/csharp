using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartkowka_konstruktory_JO.classess
{

    enum StatusSamochodu
    {
        Nowy,
        Uzywany,
        Zabytkowy
    }
    internal class Samochod
    {
        private string marka { get; set; }
        private string model { get; set; }
        private int rokProdukcji { get; set; }
        private double pojemnoscSilnika{ get; set; }
        private bool czyDiesel { get; set; }

        private DateTime dataZakupu { get; set; }
        private StatusSamochodu statusSamochodu { get; set; }

        private static string domyslnyKolor { get; set; }
        private static int domslnyPrzebieg { get; set; }

        static Samochod()
        {
            domyslnyKolor = "Bialy";
            domslnyPrzebieg = 0;
        }
        public Samochod()
        {
            marka = "Ford";
            model = "Focus";
            rokProdukcji = 2020;
            pojemnoscSilnika = 2.0;
            czyDiesel = false;
            dataZakupu = new DateTime(2020, 1, 1);
            dataZakupu.ToLongDateString();
            statusSamochodu = StatusSamochodu.Nowy;
        }
        public Samochod(string marka, string model, int rokProdukcji)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
        }
        public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
            this.pojemnoscSilnika=pojemnoscSilnika;
        }
        public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika, bool czyDiesel)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.czyDiesel = czyDiesel;
        }
        public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika, bool czyDiesel, DateTime dataZakupu, StatusSamochodu statusSamochodu)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.czyDiesel = czyDiesel;
            this.dataZakupu = dataZakupu;
            this.statusSamochodu = statusSamochodu;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {marka}, Model: {model}, Rok produkcji: {rokProdukcji}, Pojemnosc silnika: {pojemnoscSilnika}l, Diesel: {czyDiesel}, Data zakupu: {dataZakupu}, Status: {statusSamochodu}");
        }
        public void ObliczWiekSamochodu()
        {
            int roznica = DateTime.Now.Year - rokProdukcji;
            Console.WriteLine($"Wiek samochodu: {roznica} lat(a)");
        }


    }
}
