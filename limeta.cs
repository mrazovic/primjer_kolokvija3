using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class limeta : sastojak
    {
        public limeta(double kol)
        {
            porcija = 0.3;
            opis = "Soka limete ";
            volumen = porcija * kol;
        }

        public override string Prikazi()
        {
            return String.Format("{0}dcl {1}", volumen / porcija, opis);
        }

    }
}
