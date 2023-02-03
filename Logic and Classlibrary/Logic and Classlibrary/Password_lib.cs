using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Logic_and_Classlibrary
{
    public class Password_lib
    {

        public void Opret()
        {
            Console.Clear();
            
            Security();

        }

        public void Login() //Funktion for at logge ind i starten af programmet, vis der allerede er en bruger i systemet
        {
            string username; //De strings vi bruger til at gemme oplysninger
            string password;
            string PreviousUsername;
            string PreviousPassword;
            do //Kører et loop, der fortsætter indtil brugeren har indtastet de korrekte oplysninger
            {
                Console.Clear(); //rengøre skærmen, så tidligere oplysninger fjernes
                Console.WriteLine("LOGIN\n");
                Console.Write("Brugernavn".PadRight(9, ' ') + ": ");
                Console.Write("\nPassword".PadRight(9, ' ') + "  : ");
                Console.SetCursorPosition(12, 2);  //får brugeren til at skrive på brugernavn feltet
                username = Console.ReadLine(); //Bruger indtastning for brugernavnet

                Console.SetCursorPosition(12, 3); //får brugeren til at skrive på password feltet
                password = Console.ReadLine(); //Bruger indtastning for adgangskoden
                string[] text = File.ReadAllLines(@"C:\Users\davfro\Desktop\bruger\bruger.txt"); //Henter dokumentet der hvor vi gemmer bruger-oplysningerne
                PreviousUsername = text[0]; //Definerer brugernavnet
                PreviousPassword = text[1]; //Definerer adgangskoden

                if (username == PreviousUsername && password == PreviousPassword) //Checker om indtastningen er den samme som dem i dokumentet
                {
                    Console.WriteLine("\nLogin godkendt.");
                    Thread.Sleep(1500); //Venter lidt med at gå videre, så brugeren har tid til at læse beskeden
                }
                else //Hvis indtastningen ikke matcher dem i dokumentet
                {
                    Console.WriteLine("Brugernavn eller password er forkert angivet.");
                    Thread.Sleep(2000); //Venter lidt med at gå videre, så brugeren har tid til at læse beskeden
                }

            } while (username != PreviousUsername || password != PreviousPassword); //Loopet vil fortsætte indtil indtastningen matcher dem i dokumentet

        }


        public void Security() //Hvis der ikke eksisterer en bruger, vil denne funktion bede brugeren om at oprette en bruger og en adgangskode
        {
            string passwd;
            String filnavn = "bruger"; //Navnet på dokumentet hvor vi gemmer bruger oplysningerne

            Console.WriteLine("Opret en bruger!\n");
            Console.Write("Brugernavn".PadRight(9, ' ') + ": ");
            Console.Write("\nPassword".PadRight(10, ' ') + " : ");
            Console.SetCursorPosition(12, 2);
            string user = Console.ReadLine(); //Indtastning for brugernavn
            Console.SetCursorPosition(12, 3);

            do //Et loop der fortsætter indtil kravene for adgangskoden er blevet godkendt
            {
             
                passwd = Console.ReadLine();
                if (PasswordCheck(passwd) == true) //Kører en funktion der checker om indtastningen lever op til kravene
                    Console.Write("\nAccount er blever oprettet");
                

                else //Hvis indtastning ikke er korrekt, udskrives dette, tidligere indtastning bliver fjernet
                {
                    Console.SetCursorPosition(10, 3); 
                    Console.WriteLine("\n\nPassword blev ikke godkendt, prøv igen");
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("                                                   ");
                    Console.SetCursorPosition(12, 3);
                    Console.Write("                                                       ");
                    Console.SetCursorPosition(12, 3);

                }
                

            } while (PasswordCheck(passwd) != true);

            string fiktiv = user + "\n" + passwd; //Brugernavn og adgangskode, lagt sammen og gjort klar til at blive gemt i dokumentet
             File.WriteAllText(@"C:\Users\davfro\Desktop\bruger\" + filnavn + ".txt", fiktiv, Encoding.Unicode); //gemmer brugernavn og adgangskode i filen

            Thread.Sleep(1500); //Venter lidt med at gå videre, så brugeren har tid til at læse tidligere besked
        }

        static bool PasswordCheck(string passwd)
        {
            if (passwd.Length < 12 || passwd.Length > 40)
                return false;
            if (!passwd.Any(char.IsUpper))
                return false;
            if (!passwd.Any(char.IsLower))
                return false;
            if (!passwd.Any(char.IsNumber))
                return false;
            string specialCha = @"%!@#$%^&*()?/>.<,:;'|}]{[~`+=-" + "\"";
            char[] specialCh = specialCha.ToCharArray();
            foreach (char ch in specialCh)
            {
                if (passwd.Contains(ch))
                    return true;
            }
            return false;
        }

        public void Ændre()
        {
            Console.Clear();
            Console.WriteLine("Her kan du ændrer dit password");
            Console.WriteLine("Password kan ikke være det samme som sidste password");
            Console.Write("\nNyt password".PadRight(10, ' ') + ": ");

            String filnavn = "bruger";
            string password;
            string PreviousPassword;
            string[] text = File.ReadAllLines(@"C:\Users\davfro\Desktop\bruger\bruger.txt");
            PreviousPassword = text[1];

            do
            {

                password = Console.ReadLine();
                if (PasswordCheck(password) != true)
                    
                {
                    Console.SetCursorPosition(10, 3);
                    Console.WriteLine("\n\nPassword blev ikke godkendt, prøv igen");
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("                                                   ");
                    Console.SetCursorPosition(14, 3);
                    Console.Write("                                                       ");
                    Console.SetCursorPosition(14, 3);

                }


            } while (PasswordCheck(password) != true);

            if (password != PreviousPassword)
            {
                Console.WriteLine("\nPassword blev skiftet");
                Thread.Sleep(2000);
            }

            else
            {
                Console.WriteLine("\nPassword må ikke være det samme som forrige!");
                Thread.Sleep(3000);
            }
             string user = File.ReadLines(@"C:\Users\davfro\Desktop\bruger\bruger.txt").First();

            string fiktiv = user + "\n" + password;
            File.WriteAllText(@"C:\Users\davfro\Desktop\bruger\" + filnavn + ".txt", fiktiv, Encoding.Unicode);

        }


    }
}
