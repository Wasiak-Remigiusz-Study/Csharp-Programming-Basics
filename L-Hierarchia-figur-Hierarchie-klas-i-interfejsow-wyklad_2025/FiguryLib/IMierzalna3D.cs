using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{
    public interface IMierzalna3D: IMierzalna2D
    {
        double Pole { get; }
        double Powierzchnia { get; }
           
    }
}
