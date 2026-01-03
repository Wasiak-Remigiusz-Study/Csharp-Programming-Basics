// https://github.com/wsei-szkola-programowania/zadanie-klasa-trojkat

//Zadanie: klasa Trojkat
//Utwórz klasę Trojkat spełniającą następujące założenia:

//#nullable enable


class Program
{
    static void Main(string[] args)
    {


        //  Trojkat - niezmienniczy - immutable
        Console.WriteLine($"licznik: {Trojkat.Licznik}");
        var t = new Trojkat(3,4,5);
        //t.a = 1;
        Console.WriteLine(t);
        Console.WriteLine(t.A);
        Console.WriteLine(t.ObliczObwod());
        Console.WriteLine(t.Obwod);
        Console.WriteLine(t.Pole);


        var t1 = new Trojkat(3);
        Console.WriteLine(t1);
        Console.WriteLine(t1.A);



        var t2 = new Trojkat();
        Console.WriteLine(t2);
        Console.WriteLine(t2.A);



        // Static
        var t4 = Trojkat.ObiczPole(4, 5, 6);
        Console.WriteLine($"Static - Trojkat.ObiczPole: {t4}");


        Console.WriteLine($"licznik: {Trojkat.Licznik}");

        // TrojkatM - zmienniczy - mutable

        var tM = new TrojkatM(3, 4, 5);
        //tM.A = 25;
        tM.B = 5;
        Console.WriteLine(tM);
        Console.WriteLine(tM.A);
        Console.WriteLine(tM.ObliczObwod());
        Console.WriteLine(tM.Obwod);
        Console.WriteLine(tM.Pole);


    }
}