using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_and_Classlibrary;

namespace Basis_programmering
{
    internal class Dans_class:Dans_lib
    {
        public void Danse()
        {
            Console.Clear();

            Console.WriteLine("Velkommen til danseprogrammet!\n");

            Console.Write("Navn på første danser: ");
            string danser1 = Console.ReadLine();
            Console.Write("\nHvor mange points får første danser: ");
            int points1; while (!int.TryParse(Console.ReadLine(), out points1)) Console.WriteLine("Du skal kun bruge tal, tumpe!");


            Console.Write("\nNavn på anden danser: ");
            string danser2 = Console.ReadLine();
            Console.Write("\nHvor mange points får anden danser: ");
            int points2; while (!int.TryParse(Console.ReadLine(), out points2)) Console.WriteLine("Du skal kun bruge tal, tumpe!");



            Console.WriteLine("\nDanser 1 navn: " + danser1);
            Console.WriteLine("Danser 1 points: " + points1);
            Console.WriteLine("\nDanser 2 navn: " + danser2);
            Console.WriteLine("Danser 2 points: " + points2);


            var dans = new Logic_and_Classlibrary.Dans_lib();
            string samlet = dans.Dansen(points1, points2);

            Console.WriteLine("\nNavne: " + danser1 + " & " + danser2 + " har " + samlet + " points samlet!");

            Console.WriteLine("\nTryk vilkårlig knap for at vende tilbage til menuen");


            Console.ReadKey();

        }










    }
}
