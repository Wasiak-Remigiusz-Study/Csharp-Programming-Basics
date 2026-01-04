


    public class Person
    {


        // dane
        private string _familyName;
        private string _firstName;
        private DateTime _birthday;

        public string FamilyName 
        { 
            get => _familyName; 
            set
            {
                
                if (value == null)
                //if ( value.Length < 2 || value == null)
                    {
                    throw new ArgumentException("Incorrect data for FamilyName");
                }
                value = value.Trim();

                if (value.Length < 2)
                //if ( value.Length < 2 || value == null)
                {
                    throw new ArgumentException("Incorrect data for FamilyName");
                }

                var tab = value.Split('-', StringSplitOptions.RemoveEmptyEntries);
                if (tab.Length > 2)
                    throw new ArgumentException("Incorrect data for FamilyName");


                // w zansiwsku tylko litery
                foreach (var item in tab)
                {
                    var nazwisko = item;
                    if (nazwisko.Length < 2)
                        throw new ArgumentException("Incorrect data for FamilyName");

                    foreach (var c in nazwisko)
                    {
                        if (!char.IsLetter(c))
                            throw new ArgumentException("Incorrect data for FamilyName");
                     }

                // Pierwsza litera duza
                    if (!char.IsUpper(nazwisko[0]))
                        throw new ArgumentException("Incorrect data for FamilyName");
                // Reszta male litery
                    for (var i = 1; i < nazwisko.Length; i++)
                    {

                        if (!char.IsLetter(nazwisko[i]))
                            throw new ArgumentException("Incorrect data for FamilyName");
                    }
                } 
                _familyName = value;
            }
        }
        public string FirstName 
        { 
            get => _firstName;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Incorrect data for FamilyName");
                }
                _firstName = value;
            }
            
        }
        public DateTime Birthday 
        {
            get => _birthday;
            set
            {
                _birthday = value;
            }
            
        }


        // konstruktor
        public Person(string familyName, string firstName, DateTime birthday)
        {
            FamilyName = familyName;
            FirstName = firstName;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{FirstName} {FamilyName} ({Birthday:yyy-MM-dd})"; ;
        }





        // metody - zachowanie obiektu

    }


