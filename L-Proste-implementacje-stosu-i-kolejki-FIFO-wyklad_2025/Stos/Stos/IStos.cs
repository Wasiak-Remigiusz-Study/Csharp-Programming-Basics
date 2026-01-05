
namespace StosLib
{
    public interface IStos<T>
    {
        //w interfejsie nie deklaruje się konstruktora - w Interface wpisujemy SYGNATURE metod - to jest umowa/kontraktem

        //wstawia element value typu T na stos
        void Push(T value);

        //zwraca szczytowy element stosu
        T Peek { get; }

        //zdejmuje szczytowy element ze stosu
        T Pop();

        //zwraca liczbę elementów na stosie
        int Count { get; }

        //zwraca true, jeśli stos jest pusty, a false w przeciwnym przypadku
        bool IsEmpty { get; }

        //opróżnia stos
        void Clear();

        //kopiuje i eksportuje stos do tablicy
        T[] ToArray();
    }
}

