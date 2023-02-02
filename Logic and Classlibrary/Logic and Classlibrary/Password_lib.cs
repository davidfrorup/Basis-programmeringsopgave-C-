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

        public void Login()
        {
            string username;
            string password;
            string PreviousUsername;
            string PreviousPassword;
            do
            {
                Console.Clear();
                Console.WriteLine("LOGIN\n");
                Console.Write("Brugernavn".PadRight(9, ' ') + ": ");
                Console.Write("\nPassword".PadRight(9, ' ') + "  : ");
                Console.SetCursorPosition(12, 2);
                username = Console.ReadLine();

                Console.SetCursorPosition(12, 3);
                password = Console.ReadLine();
                string[] text = File.ReadAllLines(@"C:\Users\davfro\Desktop\bruger\bruger.txt");
                PreviousUsername = text[0];
                PreviousPassword = text[1];


                if (username == PreviousUsername && password == PreviousPassword)
                {
                    Console.WriteLine("\nLogin godkendt.");
                    Thread.Sleep(1500);
                }
                else
                {
                    Console.WriteLine("Brugernavn eller password er forkert angivet.");
                    Thread.Sleep(2000);
                }

            } while (username != PreviousUsername || password != PreviousPassword);


        }


        public void Security()
        {
            string passwd;
            String filnavn = "bruger";

            Console.WriteLine("Opret en bruger!\n");
            Console.Write("Brugernavn".PadRight(9, ' ') + ": ");
            Console.Write("\nPassword".PadRight(10, ' ') + " : ");
            Console.SetCursorPosition(12, 2);
            string user = Console.ReadLine();
            Console.SetCursorPosition(12, 3);


            do
            {
             
                passwd = Console.ReadLine();
                if (PasswordCheck(passwd) == true)
                    Console.Write("\nAccount er blever oprettet");
                

                else
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

             string fiktiv = user + "\n" + passwd;
             File.WriteAllText(@"C:\Users\davfro\Desktop\bruger\" + filnavn + ".txt", fiktiv, Encoding.Unicode);

            Thread.Sleep(1500);
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
