using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class led : sastojak
    {
        public led(string opis)
        {
            this.opis = "Led " + opis;
            volumen = 1;
        }

        public override string Prikazi()
        {
            return opis;
        }
    }
}
