// CR: Klasa Person (właściwości)

// Zaprojektuj klasę Person spełniającą następujące założenia:

// Dane:

// FamilyName : string, nazwisko, tylko litery (co najmniej dwie), pierwsza litera duża, pozostałe małe; 
// możliwość nazwiska dwuczłonowego - wtedy człony połączone łącznikiem (znak -), każdy człon z dużej litery, 
// pozostałe z małych (człon nazwiska składa się z co najmniej 2. liter). Próba zapamiętania wartości 
// niezgodnej z wytycznymi skutkuje zgłoszeniem wyjątku ArgumentException z komunikatem Incorrect data for FamilyName. 
// Spacje na początku i końcu należy usunąć.

// FirstName : string, imię, tylko litery (co najmniej dwie), pierwsza litera duża, pozostałe małe. 
// Próba zapamiętania wartości niezgodnej z wytycznymi skutkuje zgłoszeniem wyjątku 
// ArgumentException z komunikatem Incorrect data for FirstName. Spacje na początku i końcu należy usunąć.

// Birthday : DateTime, data urodzenia, nie później niż dzisiaj. Próba zapamiętania wartości niezgodnej z wytycznymi 
// skutkuje zgłoszeniem wyjątku ArgumentException z komunikatem Incorrect data for Birthday.

// Dane obiektu są read/write oraz obligatoryjne, zrealizuj je jako właściwości (properties).

// Zachowanie:

// metoda ToString() wypisująca dane o osobie w formacie {FirstName} {FamilyName} ({Birthday}), data urodzenia w formacie yyyy-MM-dd.
// Uwagi

// Postaraj się zapisać kod klasy używając jak najmniejszej liczby linii kodu - np. wykorzystuj metody klasy string, jeśli 
// kod miałby się powtarzać - zdefiniuj metodę prywatną, którą wykorzystasz wielokrotnie.

// Do oceny przesyłasz kod klasy Person, ewentualnie poprzedzony dyrektywami using. Nie umieszczasz go w żadnej przestrzeni nazw. 
// Twój kod (STUDENT_ANSWER) zostanie osadzony w podanym szkielecie, następnie całość zostanie skompilowana 
// i uruchomiona - dla każdego przypadku testowego oddzielnie:



using System;


namespace CR_Klasa_Person_wlasciwosci
{
    public class Program
    {
        static void Test1()
        {
            /* Test: Utworzenie obiektu, dane poprawne */
            var p1 = new Person(familyName: "Abacki",
                                firstName: "John",
                                birthday: new DateTime(year: 2000, month: 1, day: 1)
                            );
            Console.WriteLine(p1.FamilyName);
            Console.WriteLine(p1.FirstName);
            Console.WriteLine($"{p1.Birthday:yyyy-MM-dd}");
        }

        static void Test2()
        {
            /* Test: FamilyName, dane poprawne, nazwisko dwuczłonowe, ToString */
            Person p2 = new Person("Abacka-Kuś",
                                    "Ewa",
                                    new DateTime(2000, 1, 1));
            Console.WriteLine(p2);
        }

        static void Test3()
        {
            /* Test: FamilyName, dane błędne, jest null */
            Person p3 = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
            try
            {
                p3.FamilyName = null;
                Console.WriteLine(p3);
            }
            catch (ArgumentException e)
            when (e.Message == "Incorrect data for FamilyName")
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Test4()
        {

            /* Test: FamilyName, dane błędne, jest pusty string */
            Person person4 = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
            try
            {
                person4.FamilyName = "";
                //person4.FamilyName = null;
                Console.WriteLine(person4.FamilyName);
            }
            catch (ArgumentException e)
                when (e.Message == "Incorrect data for FamilyName")
            {
                Console.WriteLine(e.Message);
            }
        }


        static void Test5()
        {

            /* Test: FamilyName, spacje przed i po nazwisku powinny być usunięte */
            Person p5 = new Person("  Aaa  ", "Bbb", new DateTime(2000, 1, 1));
            Console.WriteLine(p5.FamilyName);
        }

        static void Test6()
        {
            /* Test: FamilyName, za krótkie nazwisko, po usunięciu spacji */
            Person p6 = new Person("  Aaa  ", "Bbb", new DateTime(2000, 1, 1));
            try
            {
                p6.FamilyName = "  A  ";
                Console.WriteLine(p6.FamilyName);
            }
            catch (ArgumentException e)
                when (e.Message == "Incorrect data for FamilyName")
            {
                Console.WriteLine(e.Message);
            }
        }


        static void Test7()
        {

            /* Test: FamilyName, nazwisko dwuczłonowe, za dużo członów */
            Person p7 = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
            try
            {
                p7.FamilyName = "Aaa-Bbb-Ccc";
                Console.WriteLine(p7.FamilyName);
            }
            catch (ArgumentException e)
                when (e.Message == "Incorrect data for FamilyName")
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Test8()
        {
            /* Test: FamilyName, nie dozwolone znaki */
            Person p8 = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
            try
            {
                p8.FamilyName = "Aaa.Bbb1Ccc";
                Console.WriteLine(p8.FamilyName);
            }
            catch (ArgumentException e)
                when (e.Message == "Incorrect data for FamilyName")
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Test9()
        {
            /* Test: FirstName, nie dozwolone znaki, null,
            za krótkie po usunięciu spacji, pusty string,
            */
            Person p = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
            try
            {
                p.FirstName = "Aaa.Bbb1Ccc";
                p.FirstName = null;
                p.FirstName = "  A  ";
                p.FirstName = "  ";
                p.FirstName = "  A  ";
                Console.WriteLine(p);
            }
            catch (ArgumentException e)
                when (e.Message == "Incorrect data for FirstName")
            {
                Console.WriteLine(e.Message);
            }
        }


        static void Test10()
        {
            /* Test: FamilyName, spacje przed i po imieniu powinny być usunięte */
            Person p = new Person("Aaa", "   Bbb ", new DateTime(2000, 1, 1));
            Console.WriteLine(p.FirstName);
        }

        static void Test11()
        {
            /* Test: FamilyName, spacje przed i po imieniu powinny być usunięte */
            Person p = new Person("Aaa", "   Bbb ", new DateTime(2000, 1, 1));
            Console.WriteLine(p.FirstName);
        }

        static void Test12()
        {
            /* Test: Birthday, data przyszła */
            Person p = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
            try
            {
                p.Birthday = new DateTime(DateTime.Now.Year + 1, 1, 1);

                Console.WriteLine(p);
            }
            catch (ArgumentException e)
                when (e.Message == "Incorrect data for Birthday")
            {
                Console.WriteLine(e.Message);
            }
        }





        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            Test3();
            //Test4();
            //Test5();
            Test6();
            //Test7();
            Test8();
        }

    }
}

