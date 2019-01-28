using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Koktel Mojito = new Koktel("Mojito");
            Mojito.Dodaj(new secer(2));
            Mojito.Dodaj(new limeta(0.3));
            Mojito.Dodaj(new bijeliRum(0.6, "Havana Club"));
            Mojito.Dodaj(new menta(4));
            Mojito.Dodaj(new mineralnaVoda(0.3, "Jamnica"));
            Mojito.Dodaj(new led("mrvljeni"));
            Console.WriteLine(Mojito.Posluzi());
        }
    }
}