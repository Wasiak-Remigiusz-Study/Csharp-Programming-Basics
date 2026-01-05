using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{
    public class Odcinek : Figura, IMierzalna1D, IEquatable<Odcinek>
    {
        public Punkt P1 { get; private set; }
        public Punkt P2 { get; private set; }

        public double Dlugosc => Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));

        public Odcinek(Punkt p1, Punkt p2)
        {
            P1 = p1;
            P2 = p2;
            Nazwa = $"Odcinek{Licznik}";
        }

        public override string ToString()
        {
            return $"Orcionek({P1}, {P2})";
        }

        public bool Equals(Odcinek other)
        {
            if (other == null)
            {
                return false;
            }
            return (P1.Equals(other.P1 ) && P2.Equals(other.P2)) || 
                (P1.Equals(other.P2) && P2.Equals(other.P1));
        }

        public override void Rysuj()
        {
            Console.WriteLine($"Odcinek: {Nazwa} ({P1}, {P2})");
        }
    }
}
