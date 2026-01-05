using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{
    public class Punkt: Figura, IEquatable<Punkt>
    {
        public double X { get; private set; }
        public double Y { get; private set; }


        public Punkt(double x, double y)
        {
            X = x;
            Y = y;

        }

        public override string ToString()
        {
            return $"Punkt({X}, {Y})";   
        }

        public bool Equals(Punkt other)
        {
            if (other ==null)
            {
                return   false;
            }
            return X == other.X && Y == other.Y ;
        }

        public override void Rysuj()
        {
            Console.WriteLine($"Punkt{Licznik}({X}, {Y})");
        }
    }
}
