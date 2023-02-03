using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_and_Classlibrary
{
    public class Fodbold_lib
    {
        static void Main()
        {
        }


        public void Kamp(int afleveringer, string goal)
        {
            

            goal = goal.ToLower(); // sætter goal til altid at være med småt, ligegyldigt om brugeren indtaster med stort eller blandet

            if (goal != "mål") // if statement der kører nedestående, hvis input IKKE er = mål, ellers kørende den else

            {
                if (afleveringer == 0) //Hvis afleveringer = 0, så bliver følgende writeline udskrevet
                    Console.WriteLine("Shh");

                if (afleveringer >= 10) // hvis afleveringer er 10 eller mere, udskriv writeline
                    Console.WriteLine("*High Five* - Jubel");

                else
                {
                    for (int i = 0; i < afleveringer; i++) //for-loop der tæller antallet af afleveringer
                    {
                        Console.Write("Huh! "); // udskriver "Huh!" for hver aflevering mellem 1-9
                    }
                }
            }
            else // Else-statement der udskriver vores writeline, hvis if-statementet = mål
                Console.WriteLine("Olé olé olé");

        }
    }
}
