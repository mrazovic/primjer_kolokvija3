using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class mineralnaVoda : sastojak
    {
        public mineralnaVoda(double kolicina, string opis)
        {
            porcija = 1.0;
            volumen = kolicina * porcija;
            this.opis = "Mineralna voda " + opis;
        }

        public override string Prikazi()
        {
            return String.Format("{0}dcl {1}", volumen / porcija, opis);
        }
    }
}
