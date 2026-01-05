using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{
    public class Kolo : Okrag
    {
        public Kolo(Punkt srodek, double promien) : base(srodek, promien)
        {
            Nazwa = $"Kolo{Licznik}";
        }
    }
}
