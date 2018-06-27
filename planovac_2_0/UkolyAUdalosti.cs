using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planovac_2_0
{
    public class Udalost
    {
        public DateTime datum { get; set; }
        public string nazev { get; set; }
        public string druh { get; set; }
        public string popis { get; set; }

        //Parametrický konstruktor pro vytvoření události
        public Udalost(string nazev, string druh, string popis, int den, int mesic, int rok)
        {

            this.nazev = nazev;
            this.druh = druh;
            this.popis = popis;
            this.datum = new DateTime(rok, mesic, den);
        }

        //Bezparametrický konstruktor využitý pro čtení a zápis do souboru xml
        public Udalost() { }

        //Výpis data v dlouhé podobě
        public string getDatum()
        {
            return datum.ToLongDateString();
        }

        //Metoda toString
        public string toString()
        {
            string druh;
            string podrobnosti;
            if (this.druh.Equals(""))
            {
                druh = "Bez určení druhu";
            }
            else
            {
                druh = this.druh;
            }
            if (this.popis.Equals(""))
            {
                podrobnosti = "Bez podrobností";
            }
            else
            {
                podrobnosti = this.popis;
            }
            string veta = String.Format("Datum události: {0} \nNázev události: {1}\nDruh události: {2}\nPodrobnosti o události: {3}", this.getDatum(), this.nazev, druh, podrobnosti);
            return veta;
        }
    }

    public class Ukol : Udalost
    {
        public int hodina { get; set; }
        public int minuta { get; set; }

        //Parametrický konstruktor pro vytvoření události, který rozšiřuje konstruktor pro úkol
        public Ukol(string nazev, string druh, string popis, int den, int mesic, int rok, int hodina, int minuta) : base(nazev, druh, popis, den, mesic, rok)
        {
            this.hodina = hodina;
            this.minuta = minuta;
        }

        //Bezparametrický konstruktor využitý pro čtení a zápis do souboru xml
        public Ukol(){ }

        //Výpis času ve tvaru hh:mm
        public string getCas()
        {
            string vysledek = String.Format("{0:00}:{1:00}", hodina, minuta);
            return vysledek;
        }

        //Metoda toString
        public new string toString()
        {
            string druh;
            string podrobnosti;
            if (this.druh.Equals(""))
            {
                druh = "Bez určení druhu";
            }
            else
            {
                druh = this.druh;
            }
            if (this.popis.Equals(""))
            {
                podrobnosti = "Bez podrobností";
            }
            else
            {
                podrobnosti = this.popis;
            }
            string veta = String.Format("Datum úkolu: {0} \nČas úkolu: {1}\nNázev ůkolu: {2}\nDruh úkolu: {3}\nPodrobnosti o úkolu: {4}", this.getDatum(), this.getCas(), this.nazev, druh, podrobnosti);
            return veta;
        }
    }
}
