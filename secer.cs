using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class secer : sastojak
    {
        public secer(double kol)
        {
            porcija = 2;
            opis = "Secera";
            volumen = porcija / kol;
        }

        public override string Prikazi()
        {
            return String.Format("{0} zlice {1}", volumen, opis);
        }
    }
}
