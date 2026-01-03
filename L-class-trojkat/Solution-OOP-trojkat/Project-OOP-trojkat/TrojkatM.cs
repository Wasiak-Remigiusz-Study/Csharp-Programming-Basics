#nullable disable


// ------  mutable
public class TrojkatM
{
    private double a;
    private double b;
    private double c;

    public double A 
    { 
        get => a;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Boki muszą byc dodatnie");
            // warunek trojkata
            if (value + B <= C || value + C <= B || B + C <= value)
                throw new ArgumentException("Nie spełniony warynek trjkąta");
            a = value;
        }
    }
    public double B 
    { 
        get => b;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Boki muszą byc dodatnie");
            // warunek trojkata
            if (A + value <= C || A + C <= value || value + C <= A)
                throw new ArgumentException("Nie spełniony warynek trjkąta");
            b = value;
        }
    }
    public double C 
    { 
        get => c;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Boki muszą byc dodatnie");
            // warunek trojkata
            if (A + B <= value || A + value <= B || B + value <= A)
                throw new ArgumentException("Nie spełniony warynek trjkąta");
            c = value;
        }
    }

    public static int Licznik { get; private set; } = 0;

    //-- Technika łańcuchowania kodu 

    // Konstruktor
    public TrojkatM(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Boki muszą byc dodatnie");
        // warunek trojkata
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Nie spełniony warynek trjkąta");
        this.a = a;
        this.b = b;
        this.c = c;

        Licznik++;
    }

    // Technika łańcuchowania kodu - czyli kod, który buduje logikę powinien być napisany tylko RAZ
    // Konstruktor przeciążony
    public TrojkatM() : this(1, 1, 1) { }


    // Konstruktor - ktory dla podanej wartości tworzy trojkat rownoboczny
    public TrojkatM(double a) : this(a, a, a) { }


    // zachowanie - za pomocą funkcji

    public override string ToString() => $"Trojkat({A}, {B}, {C})";

    public double Obwod => A + B + C;

    public double ObliczObwod()
    {
        return A + B + C;
    }

    public double Pole
    {
        get
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

}

