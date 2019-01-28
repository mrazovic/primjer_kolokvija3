using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bijeliRum : sastojak
    {
        public bijeliRum(double volumen, string opis)
        {
            this.volumen = volumen;
            this.opis = "Ruma " + opis;
        }

        public override string Prikazi()
        {
            return String.Format("{0}dcl {1}", VratiDecilitre(), opis);
        }
    }
}
