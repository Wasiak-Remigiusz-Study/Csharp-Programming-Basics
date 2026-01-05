#nullable disable

var o = new Osoba(
                "Nowak",
                "Jan",
                new DateOnly(2000, 1, 1)
                 );


Console.WriteLine(o.ToString()); // wywyłujemy jawnie
Console.WriteLine(o);// wywyłujemy niejawnie

o.Nazwisko = "Abacki";
Console.WriteLine(o);
// o.pesel = "12345";
Console.WriteLine(o + $" pesel: {o.pesel}");



// Property
Console.WriteLine(o.Wiek);
// Funckja
Console.WriteLine(o.ObliczWiek());


// ---- Dziedziczenie

var m = new Osoba("Kowalska",
                "Anna",
                new DateOnly(2000, 1, 1)
                 );

var d = new Dziecko(
                //"Nowak",
                "Janek",
                new DateOnly(2020, 1, 1),
                matka:m,
                ojciec: o);

Console.WriteLine(d);// wywyłujemy niejawnie





