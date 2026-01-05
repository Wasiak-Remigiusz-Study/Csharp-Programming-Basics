using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{
    abstract public class Figura
    {
        static public int Licznik { get; private set; } = 0;
        public string Nazwa { get; set; }

        public Figura() 
        {
            Licznik++;
            Nazwa = $"Fig {Licznik}";

        }
        abstract public void Rysuj();
    }
}
