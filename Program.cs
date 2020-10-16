using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace LexiconConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            string CustomerChoice;
            bool Choice = true;

            //Showing menu screen
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine("¤ Välkommen till Lexicon prova project tittar på       ¤ " + "{0}" +
                              "¤ menysystem och valjä vilken funktionalitet som ska   ¤" + "{0}" +
                              "¤ köras eller välja 0 att stänga.                      ¤{0}",
                                Environment.NewLine);
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine("¤                1.  Skriver ut \"HelloWorld\"         ¤{0}" +
                              "¤                2.  Ingångsutgång                     ¤{0}" +
                              "¤                3.  Ändra textfärg                    ¤{0}" +
                              "¤                4.  Dagens datum                      ¤{0}" +
                              "¤                5.  Jämför antal                      ¤{0}" +
                              "¤                6.  Gissa slumpmässigt nummer         ¤{0}" +
                              "¤                7.  Spara fil på disk                 ¤{0}" +
                              "¤                8.  Läs File från disk                ¤{0}" +
                              "¤                9.  Rooting number                    ¤{0}" +
                              "¤                10. Multiplikationstabell             ¤{0}" +
                              "¤                11. Slumpmässiga array                ¤{0}" +
                              "¤                12. Palindrome                        ¤{0}" +
                              "¤                13. Siffror mellan ingången           ¤{0}" +
                              "¤                14. Sortera udda och jämna            ¤{0}" +
                              "¤                15. Lägg till kommaseparerade nummer  ¤{0}" +
                              "¤                16. karaktär och motståndare klass    ¤{0}" +
                              "¤                0. Avbryt                             ¤{0}",
                              Environment.NewLine);
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");

            //Loop through the user's choice
            do
            {

                Console.Write("Ange din välj:");
                CustomerChoice = Console.ReadLine();

                switch (CustomerChoice)
                {
                    case "0":
                        return;
                    case "1":
                        PrintHelloWorld();
                        break;
                    case "2":
                        InputOutput();
                        break;
                    case "3":
                        ChangeTextColor();
                        break;
                    case "4":
                        TodaysDate();
                        break;
                    case "5":
                        CompareNumber();
                        break;
                    case "6":
                        GuessRandomNumber();
                        break;
                    case "7":
                        SaveFile();
                        break;
                    case "8":
                        ReadFile();
                        break;
                    case "9":
                        RootingNumber();
                        break;
                    case "10":
                        MuliplicationTable();
                        break;
                    case "11":
                        RandomNumberArray();
                        break;
                    case "12":
                        Palindrome();
                        break;
                    case "13":
                        NumbersInbetween();
                        break;
                    case "14":
                        SortOddAndEven();
                        break;
                    case "15":
                        AddCommaSeparatedNumbers();
                        break;
                    case "16":
                        CharacterOposition();
                        break;
                    default:
                        Console.WriteLine("Fel välj");
                        Choice = false;
                        break;
                }

            } while (Choice == true);
        }

        // 1. Funktion som skriver ut ”Hello World” i konsolen
        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        // 2. Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut dessa i konsolen
        public static void InputOutput()
        {
            // declaring variable 
            string FirstName;
            string LastName;
            int Age;

            Console.Write("Ange din förnamn: ");
            FirstName = Console.ReadLine();

            Console.Write("Ange din efternamn: ");
            LastName = Console.ReadLine();

            Console.Write("Ange din ålder: ");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ditt name är : {FirstName} {LastName}");
            Console.WriteLine($"Du är {Age} år gammal");

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        //3. Funktion som ändrar färgen på texten i konsolen(och ändrar tillbaka om man använder funktionen igen.
        public static void ChangeTextColor()
        {
            //Check if the forground color is green 
            if (Console.ForegroundColor == ConsoleColor.Green)
                Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Gray;
            else
                // Change forground color 
                Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        //4 Funktion för att skriva ut dagens datum
        public static void TodaysDate()
        {
            // declaring variable 
            Console.WriteLine(DateTime.Today.ToShortDateString());
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        //5. Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst
        public static void CompareNumber()
        {
            // declaring variable
            int Num1;
            int Num2;

            Console.Write("Ange första nummer : ");
            Num1 = int.Parse(Console.ReadLine());

            Console.Write("Ange andra nummer : ");
            Num2 = int.Parse(Console.ReadLine());

            //Check for conditions 
            if (Num1 > Num2)
                Console.WriteLine($"{ Num1} är större än { Num2}");
            else if (Num2 > Num1)
                Console.WriteLine($"{Num2} är större än {Num1}");
            else
                Console.WriteLine("Nummer är lika!");

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        /* 6. Funktion som genererar att slumpmässigt tal mellan 1 och 100. Användaren ska sedan gissa
        talet.Gissar användaren rätt så ska ett meddelande säga detta, samt hur många försök det
       tog.Gissar användaren fel ska ett meddelande visas som informerar ifall talet var för stort
       eller för litet*/

        public static void GuessRandomNumber()
        {
            // declaring variable
            int randomNum = new Random().Next(1, 101);
            int Num;
            int Attempt = 0;

            Console.WriteLine("Vi har numret mellan 1 till 100, kan du gissa numret?");

            do
            {
                Console.Write("Ange nummer: ");
                Num = int.Parse(Console.ReadLine());

                Attempt = Attempt + 1;

                if (Num > randomNum)
                {
                    Console.WriteLine("Numret är högt ");
                }
                else if (randomNum > Num)
                {
                    Console.WriteLine("Numret är lågt");
                }
                else
                {
                    Console.WriteLine($"Du har försoker {Attempt} ");
                    Console.WriteLine("Grattis! Du har gissat rätt nummer!");
                }
            } while (Num != randomNum);

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        //7. Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken
        public static void SaveFile()
        {
            // declaring variable
            string path = @"C:\File.txt";
            string UserText;

            //Create the file.
            using (FileStream fs = File.Create(path))
            {
                Console.WriteLine("Ange din text");
                UserText = Console.ReadLine();
                //encoding format
                UTF8Encoding FileEncoding = new UTF8Encoding(true);
                //Convert array of character to array of bytes using UTF8-encoding
                byte[] UserBytes = FileEncoding.GetBytes(UserText);
                //Write bytes to file
                fs.Write(UserBytes);
            }
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        /*8. Funktion där en fil läses in från hårddisken (för enkelhetens 
         * skull kan man använda filen från uppgift 7)*/
        public static void ReadFile()
        {
            // Path to read file
            string path = @"C:\File.txt";
            //array buffer to store bytes
            byte[] FileBytes = new byte[1000];
            //encoding format
            UTF8Encoding FileEncoding = new UTF8Encoding(true);
            //Open stream with read mode 
            using (FileStream fs = File.OpenRead(path))
            {
                //Read bytes from file and fill them in FileBytes buffer, return the number of bytes
                int ByteCount = fs.Read(FileBytes, 0, 1000);
                //Convert bytes to string
                string FileText = FileEncoding.GetString(FileBytes, 0, ByteCount);

                Console.WriteLine(FileText);

            }
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        /*9. Funktion där användaren skickar in ett decimaltal och får tillbaka roten ur,
         * upphöjt till 2 och upphöjt till 10*/
        public static void RootingNumber()
        {
            // declaring variable
            double Num;

            Console.Write("Ange ett decimaltal: ");
            Num = double.Parse(Console.ReadLine());

            double Root2 = Math.Pow(Num, 1.0 / 2.0);
            double Root10 = Math.Pow(Num, 1.0 / 10.0);
            Console.WriteLine($"Roten upphöjt till 2: {Root2}");
            Console.WriteLine($"Roten upphöjt till 10: {Root10}");

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        /*10. Funktion där programmet skriver ut en multiplikationstabell från 1 till 10.
         * En ”tab” ska läggas in efter varje nummer.Försöka att ställa upp det så det
         * blir relativt läsbart.*/
        public static void MuliplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0, 11}", $"{j}x{i} = {j * i}\t");
                }

                Console.WriteLine();
            }
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }


        /*11. Funktion som skapar två arrayer.Den första fylls med slumpmässiga tal.
         * Den andra fylls med talen från den första i stigande ordning*/

        public static void RandomNumberArray()
        {

            // declaring array
            int[] FisrtArray = new int[10];

            //int[] SecondArray = new int[10];

            //filling first array
            for (int i = 0; i < FisrtArray.Length; i++)
            {
                FisrtArray[i] = new Random().Next(1, 20);
            }

            //printing fist array
            Console.WriteLine("First Array: ");
            for (int i = 0; i < FisrtArray.Length; i++)
            {
                Console.WriteLine(FisrtArray[i]);
            }

            // second array
            var SecondArray = FisrtArray.OrderBy(x => x).ToArray();

            //printing second array
            Console.WriteLine("Second array: ");
            for (int i = 0; i < SecondArray.Length; i++)
            {
                Console.WriteLine(SecondArray[i]);
            }

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }


        /*12. Funktion som tar en input från användaren och kontrollerar ifall det
         * är en palindrom (alltså samma ord från båda håll, såsom Anna eller radar.*/
        public static void Palindrome()
        {
            // declaring variable
            string UserInput;

            Console.WriteLine("Ange din input att kolla om det är palindrom");
            UserInput = Console.ReadLine();

            char[] UserInputChar = UserInput.ToCharArray();
            var Towards = new List<char>();
            var Backwards = new List<char>();

            for (int i = 0; i < UserInputChar.Length; i++)
            {
                Towards.Add(UserInputChar[i]);
            }

            for (int i = UserInputChar.Length - 1; i >= 0; i--)
            {
                Backwards.Add(UserInputChar[i]);
            }
            //for test
            Console.WriteLine(Backwards.ToArray());

            //Convert list to string and remove space to allow "palindrome sentence" to be detecte, if tested
            string TowardsString = string.Join("", Towards).ToLower().Replace(" ", "");

            //string TowardsString = UserInput.ToLower();
            string BackwordString = string.Join("", Backwards).ToLower().Replace(" ", "");

            //Compare two list
            if (TowardsString == BackwordString)
            {
                Console.WriteLine("Input är en palindrom");
            }
            else
            {
                Console.WriteLine("Input är inte en palindrom");
            }

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        /* 13. Funktion som tar två inputs från användaren och skriver sedan ut alla
         * siffror som är mellan de två inputsen.*/
        public static void NumbersInbetween()
        {
            // declaring variable, assume the number is integer
            int Input1;
            int Input2;
            //Allow user to inter numbers
            Console.Write("Ange det första numret: ");
            Input1 = int.Parse(Console.ReadLine());

            Console.Write("Ange det andra numret: ");
            Input2 = int.Parse(Console.ReadLine());

            //apply conditions and print the numbers
            if (Input1 > Input2)
            {
                for (int i = Input2 + 1; i < Input1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = Input1 + 1; i < Input2; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        /* 14. Funktion där användaren skickar in ett antal värden (komma-separerade siffror) som sedan
         * sorteras och skrivs ut efter udda och jämna värden.*/
        public static void SortOddAndEven()
        {
            // declaring variable
            string Numbers;
            var OddNumbers = new List<int>();
            var EvenNumbers = new List<int>();

            //Reading numbers from user
            Console.Write("Skickar in ett antal värden (komma-separerade siffror): ");
            Numbers = Console.ReadLine();

            //Convert string to list
            var NumbersList = Numbers.Split(",").ToList();

            //apply condition to set out even and odd numbers
            foreach (var x in NumbersList)
            {
                var n = int.Parse(x);
                if (n % 2 == 0)
                    EvenNumbers.Add(n);
                else
                    OddNumbers.Add(n);
            }

            //displaying odd numbers
            Console.Write("Udda värden :");
            foreach (var x in OddNumbers)
                Console.Write(x + ",");
            Console.WriteLine();

            //displaying even numbers
            Console.Write("Jämna värden :");
            foreach (var y in EvenNumbers)
                Console.Write(y + ",");
            Console.WriteLine();

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }

        /* 15. Funktion där användaren skriver in ett antal värden(komma-separerade siffor)
         * som sedan adderas och skrivs ut.*/

        public static void AddCommaSeparatedNumbers()
        {
            // declaring variable
            string Numbers;
            int sum = 0;

            //Reading numbers from user
            Console.Write("Skickar in ett antal värden (komma-separerade siffror): ");
            Numbers = Console.ReadLine();

            //Convert string to list
            var NumbersList = Numbers.Split(",").ToList();

            //Convert numbers to int and add them
            foreach (var x in NumbersList)
            {
                var n = int.Parse(x);
                sum = sum + n;
            }
            Console.WriteLine("Summan av {0} är {1}", Numbers, sum);

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }


        /* 16. Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare. 
         * Funktionen skall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur,
         * som sparas i en instans av en klass*/
        public class Character
        {
            private string Name { get; set; }
            public float Strength { get; set; }
            public float Health { get; set; }
            public float Luck { get; set; }

            public Character(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return $"Name: {Name}, Strength: {Strength}, Health: {Health}, Luck: {Luck}";
            }
        }

        public static void CharacterOposition()
        {
            // declaring variable
            string CharacterName;
            string OpositionName;

            Console.Write("Ange din karaktär: ");
            CharacterName = Console.ReadLine();

            Console.Write("Ange din motståndare: ");
            OpositionName = Console.ReadLine();

            Character MinCharacter = new Character(CharacterName);
            MinCharacter.Health = new Random().Next(1, 101);
            MinCharacter.Luck = new Random().Next(1, 101);
            MinCharacter.Strength = new Random().Next(1, 101);

            Character Oposition = new Character(OpositionName);
            Oposition.Health = new Random().Next(1, 101);
            Oposition.Luck = new Random().Next(1, 101);
            Oposition.Strength = new Random().Next(1, 101);

            Console.WriteLine(MinCharacter.ToString());
            Console.WriteLine(Oposition.ToString());

            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        }
    }
}
