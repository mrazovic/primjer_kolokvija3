using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class menta : sastojak
    {
        public menta(double kol)
        {
            porcija = 5;
            opis = "Listova mente";
            volumen = porcija * kol;
        }

        public override string Prikazi()
        {
            return String.Format("{0} {1}", volumen / porcija, opis);
        }
    }
}
