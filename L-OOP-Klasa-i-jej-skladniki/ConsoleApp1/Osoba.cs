public class Osoba
{

    // dane
    public string nazwisko;

    private string imie;

    public string Imie
    {
        get => imie;
        private set => imie = value.Trim().ToUpper();
    }

    private string pesel;
    private DateOnly dataUrodzenia;


    public DateOnly DataUrodzenia
    {
        get => dataUrodzenia;
        private set
        {
            if (value.Year < 1900)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                            "Data urodzenia nie może być wcześniejsza niż 1900");
            }
            dataUrodzenia = value;
        }
    }


    // konstruktor
    public Osoba(string nazwisko, string imie, DateOnly dataUrodzenia)
    {
        this.nazwisko = nazwisko;
        this.imie = imie;
        this.pesel = GenerujPESEL();
        DataUrodzenia = dataUrodzenia;
    }

 


    // tekstowa reprezentacja obiektu
    public override string ToString()
    {
        return $"{imie} {nazwisko}";
    }

    // metody

    private string GenerujPESEL()
    {
        // DataUrodzenia = new DateOnly(2000,1,1);
        return "12345678901";
    }


}

