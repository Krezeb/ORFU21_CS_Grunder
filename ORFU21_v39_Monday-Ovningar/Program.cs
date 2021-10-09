using System;

namespace ORFU21_v39_Monday_Ovningar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning: Klasser - Grunder
            /*
             * Skapa en klass som heter Person. Ange två fält på klassen: name och age. 
             * Fälten ska inte vara nåbara utanför klassen. 
             * Välj en rimlig datatyp för vardera fält.
             * Lägg till en konstruktor i Person-klassen som tar in två parametrar, en för varje fält. 
             * Konstruktorn ska sätta värden på de två fälten från värdet på de två parametrarna.
             * Skapa en klass som heter Account. Ange ett fält på klassen: amount. 
             * Fältet ska vara nåbart utanför klassen.
             * I Program.cs skapa två instanser av klassen Person med värden enligt:
             * Person 1: name = ’Olle’, age = 12
             * Person 2: name = ’Olga’, age = 33
             * I Program.cs skapa en instans av klassen Account. 
             * Spara instansen i en variabel och sätt därefter värdet på fältet amount till 1234.56.
             */

            Person kund1 = new Person("Olle", 12);
            Person kund2 = new Person("Olga", 33);

            Account account1 = new();
            account1._amount = 1234.56;

            //Övning: Klasser - Mer Konstruktorer
            /*
             * Skapa en klass som heter Product. 
             * Ange ett fält på klassen för produktens ålder. Dvs, antal år sedan den skapades. 
             * Skapa två konstruktorer i klassen.
             * Den första tar en int-parameter som anger åldern.
             * Den andra tar ingen parameter och sätter åldern till 0 genom att anropa den andra konstruktorn.
             * I Program.cs skapa två instanser av Product genom att använda kortformen av new.
             * -Den första instansen anger ingen ålder.
             * -Den andra instansen anger en ålder på 10 år.
             * Skapa en klass som heter Bicycle. 
             * Ange två fält på klassen för cykelns ålder och nuvarande växel. 
             * Skapa tre konstruktorer i klassen.
             * -Den första tar två parametrar. En för varje fält i klassen
             * -Den andra tar en parameter för cykelns ålder och sätter den nuvarande växeln till 1.
             * -Den tredje tar inte några parametrar och sätter cykelns ålder till 0 och nuvarande växel till 1.
             */

            Produkt p1 = new();
            Produkt p2 = new(10);

            Bicycle b1 = new(7, 25);
            b1.ShowInfo();

            //Övning: Klasser - Metoder
            /*
             * Skapa en klass som heter Movie. 
             * -Klassen ska ha ett fält för filmens titel och ett för hur många som sett filmen. 
             * -Antalet som sett filmen ska från början vara 0.
             * Skapa en metod för när en person sett filmen. 
             * -Metoden ska öka fältet för antal tittningar med 1.
             * Skapa en klass som heter Additor. 
             * -Klassen ska ha två int-fält som båda sätts via konstruktorn.
             * -Skapa en metod i klassen som adderar de två fälten och returnerar summan av additionen.
             * Skapa en instans av Additor i Program.cs och skriv ut värdet du får av att anropa din metod.
             * Skapa en klass heter Subtractor.
             * -Klassen har inga fält och vi definierar ingen konstruktor.
             * -Klassen ska ha en metod som tar in två int-parametrar.
             * -Metoden ska beräkna det första värdet minus det andra värdet och returnera resultatet.
             * -Skapa en instans av Subtractor i Program.cs och skriv ut värdet du får av att anropa din metod.
             */

            Additor a1 = new(5, 12);
            Console.WriteLine($"Method \"Add\" of instance a1 : {a1.Add()}");

            Subtractor s1 = new();
            Console.WriteLine($"Method \"Subtract\" of instance s1 : {s1.Subtract(10, 3)}");

            //Övning: Klasser - Metoder 2
            /*
             * 1. 
             * Lägg till en metod i Movie-klassen vi skapade tidigare. 
             * Metoden ska heta DescribeMovie och returerna en sträng på formatet:
             * -”The movie is called [movie title] and has been seen by {view count} people”. 
             * Använd expression body-syntaxen för att lösa uppgiften.
             * 2. 
             * På Person-klassen vi skapade tidigare vill vi lägga till möjligheten att sätta personens ålder. 
             * Det ska bara vara möjligt att sätta åldrar mellan 1 och 100 år. 
             * Använd därför en setter-metod som kontrollerar parameter-värdet innan åldern sätts. 
             * Om värdet är mindre än 1 så sätt det till 1. 
             * Om värdet är högre än 100 sätt det till 100.
             * 3. 
             * Skapa en klass som heter IntPair. 
             * Klassen ska spara två int-värden. 
             * Det ska vara möjligt att hämta ut båda värdena samt medelvärdet av dem. 
             * Det ska också vara möjligt att ändra de två int-värdena. 
             * För att göra uppgiften intressant ska medelvärdet förberäknas när värdena sätts. 
             * Dvs, om någon av värdena ändras ska medelvärdet beräknas igen. 
             * Använd de koncept du lärt dig hittills för att göra en lösning för medelvärdet 
             * aldrig kan hamna ur synk med de två värdena.
             */

            Console.WriteLine("\nMovie Stuff---------------------------------");
            Movie defaultMovie = new();
            defaultMovie.GetMovieInfo();
            defaultMovie.AddView();
            defaultMovie.GetMovieInfo();
            defaultMovie.AddView(25);
            defaultMovie.GetMovieInfo();

            Console.WriteLine("\nNumber stuff---------------------------------");
            InitPair t1 = new();
            Console.WriteLine($"Result of init {t1.GetAverage()}\n");
            t1.SetNum(8, 12);
            t1.GetAllNums();
            Console.WriteLine($"_num1 is : {t1.GetNumOne()}");
            Console.WriteLine($"_num2 is : {t1.GetNumTwo()}");
            Console.WriteLine($"_sumAverage is : {t1.GetAverage()}\n");
            t1.SetNumOne(32);
            t1.SetNumTwo(8);
            t1.GetAllNums();
            Console.WriteLine($"_num1 is : {t1.GetNumOne()}");
            Console.WriteLine($"_num2 is : {t1.GetNumTwo()}");
            Console.WriteLine($"_sumAverage is : {t1.GetAverage()}");

            //Övning: Klasser - Properties
            /*
             * 1. 
             * Ändra i Person-klassen så att personens namn och ålder är properties. 
             * Personens namn ska inte gå att sätta och åldern ska ha samma kontroll som i setter-metoden.
             * 2.
             * Ändra i IntPair-klassen så att de två int-värdena och deras medelvärde är properties.
             * 3.
             * Ändra i IntPair-klassen så att property:n för medelvärdet beräknas när vi hämtar värdet 
             * för den property:n. 
             * Ta även bort backing field för medelvärdet och alla logik som använder sig av det fältet.
             */

            Console.WriteLine("\nProperty stuff---------------------------------");
            Person testPropPer1 = new();
            testPropPer1.Age = -10;
            Console.WriteLine($"testProp1.Age = {testPropPer1.Age}");

            Person testPropPer2 = new();
            testPropPer2.Age = 35;
            Console.WriteLine($"testProp1.Age = {testPropPer2.Age}");

            Person testPropPer3 = new();
            testPropPer3.Age = 150;
            Console.WriteLine($"testProp1.Age = {testPropPer3.Age}");

            InitPair testPropMath3 = new();
            testPropMath3.PropNumOne = 10;
            testPropMath3.PropNumTwo = 15;
            Console.WriteLine($"testPropMath3.PropArea = {testPropMath3.PropArea}");


            //Övning: Klasser - Properties 2
            /*
             * 1. 
             * Skapa en klass som heter Coordinate. 
             * Klassen ska ha två get-only auto-generated property:s (X och Y). 
             * Klassen ska också ha två metoder: MoveLeft och MoveRight(). 
             * Metoderna ska skapa upp en ny instans av klassen Coordinate men sätta nya värden för X-property:n. 
             * Den skapade Coordinate-instansen ska returneras av de två metoderna. 
             * MoveLeft ska minska värdet på X med 1 och MoveRight ska öka värdet med 1.
             * -Obs: i våra exempel har vi mest tittat på enkla datatyper. 
             * Det är ingen skillnad på att returnera int eller en klass vi skapat själva.
             * 2.
             * Skapa upp en klass som heter Settings. 
             * Klassen ska ha tre bool-properties: IsDarkMode, IsVerticalLayout, och IsPowerUser. 
             * Property:sarna ska vara get+init.
             * Skapa två instanser av Settings-klassen och sätt olika värden på de tre property:sarna med hjälp av Object initializer syntax
             */
            Console.WriteLine("\nMoar Property stuff---------------------------------");
            Coordinate newGame = new();

            newGame.GetPosition();
            newGame.MoveLeft();
            newGame.MoveLeft();
            newGame.MoveLeft();
            newGame.MoveLeft();
            newGame.GetPosition();
            newGame.MoveRight();
            newGame.MoveRight();
            newGame.MoveRight();
            newGame.GetPosition();

            Console.WriteLine("\nSettings Menu 1---------------------------------");
            Settings settingOne = new()
            {
                IsDarkMode = true,
                IsPowerUser = true,
                IsVerticleLayout = false
            };
            settingOne.ShowCurrentSettings();

            Console.WriteLine("\nSettings Menu 2---------------------------------");
            Settings settingTwo = new()
            {
                IsDarkMode = true,
                IsPowerUser = false,
                IsVerticleLayout = true
            };
            settingTwo.ShowCurrentSettings();
        }
    }
}
