using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_and_Classlibrary;

namespace Basis_programmering
{
    internal class Fodbold_class
    {
        public void Fodbolden()
        {
            Console.Clear(); 

            Console.WriteLine("Velkommen til Fodboldprogrammet!\n");

                Console.WriteLine("Hvor mange afleveringer bliver der lavet i kampen?");

                int afleveringer; while (!int.TryParse(Console.ReadLine(), out afleveringer)) Console.WriteLine("Du skal kun bruge tal, tumpe!");
                Console.WriteLine("Skriv 'mål' hvis der bliver scoret.");
                string goal = Console.ReadLine();
                var fodbold = new Logic_and_Classlibrary.Fodbold_lib();
                fodbold.Kamp(afleveringer, goal);


            Console.WriteLine("\nTryk vilkårlig tast for at komme tilbage til menuen");
            Console.ReadKey(); 

        }
    }
}
