using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{
    public class Okrag: Figura, IMierzalna1D, ISkalowalna
    {
        public Punkt Srodek { get; set; }
        public double Promien { get; set; }

        public double Dlugosc => 2 * Math.PI * Promien;

        public Okrag(Punkt srodek, double promien)
        {
            Srodek = srodek;
            Promien = promien;  

        }

        public override void Rysuj()
        {
            Console.WriteLine($"Okrag: {Nazwa} ({Srodek}, {Promien})");
        }

        public void Skaluj(double wspolczynnik)
        {
            if (wspolczynnik <=0)
            {
                throw new ArgumentException("wspolczynnik musi byc dodatni");
            }
            Promien*=wspolczynnik;
        }
    }
}
