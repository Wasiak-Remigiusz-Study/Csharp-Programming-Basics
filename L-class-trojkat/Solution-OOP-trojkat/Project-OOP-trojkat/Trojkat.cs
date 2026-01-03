//#nullable enable

// ------  immutable
public class Trojkat
{
    //public static int licznik = 0;
    public static int Licznik { get; private set; } = 0;

    

    // Pola (hermetyzacja/enkapsukacja)
    //readonly double a;
    //double a;
    //public readonly double a;
    //readonly double b;
    //readonly double c;
    public double A { get; private set; }
    public double B { get; }
    public double C { get; }

    //-- Technika łańcuchowania kodu 

    // Konstruktor
    public Trojkat(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Boki muszą byc dodatnie");
        // warunek trojkata
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Nie spełniony warynek trjkąta");
        A = a;
        B = b;
        C = c;

        Licznik++;
    }

    // Technika łańcuchowania kodu - czyli kod, który buduje logikę powinien być napisany tylko RAZ
    // Konstruktor przeciążony
    public Trojkat() : this(1, 1, 1) { }


    // Konstruktor - ktory dla podanej wartości tworzy trojkat rownoboczny
    public Trojkat(double a) : this(a, a, a) { }


    // zachowanie - za pomocą funkcji

    public override string ToString() => "Trojkat({A}, {B}, {C})";

    public double Obwod => A + B + C;

    public double ObliczObwod()
    { 
        return  A + B + C; 
    }

    public double Pole
    { get
        {
            var p = Obwod / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }



    static public double ObiczPole(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Boki muszą byc dodatnie");
        // warunek trojkata
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Nie spełniony warynek trjkąta");
        var p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    //public void foo()
    //{
    //    A = 8;
    //}

}

