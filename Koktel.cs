using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Koktel
    {
        static List<sastojak> sastojci = new List<sastojak>();

        private string naziv;

        public Koktel(string naziv)
        {
            this.naziv = naziv;
        }

        public void Dodaj(sastojak s)
        {
            sastojci.Add(s);
        }

        public string Posluzi()
        {
            string cocktail = "Posluzuje se koktel " + naziv + "\nSastojci: (" + sastojci.Count() + ")\n";
            double izracun = 0;

            foreach(sastojak s in sastojci)
            {
                cocktail += s.Prikazi() + "\n";
                izracun += s.VratiDecilitre();
            }

            return String.Format(cocktail + "Potrebna je casa sa minimalno dcl: " + izracun);
        }
    }
}
