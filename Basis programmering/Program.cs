using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Basis_programmering;
using Logic_and_Classlibrary;

namespace Basis_programmering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var password = new Password_class();
            password.Passwordet();

            // https://docs.google.com/document/d/11rcGItv3fVdKDW1a2cRgYI247GApdGHC6XVKohEGu0c/edit?usp=sharing ¯\_(ツ)_/¯
            do
            { 
                Console.Clear();
                Console.WriteLine("Velkommen til Programmet der vælger programmer! \n");
                Console.WriteLine("Her kan du vælge hvilket program du vil kører. \n");
                Console.WriteLine("Tryk 1. for fodbold-programmet");
                Console.WriteLine("Tryk 2. for danse-programmet");
                Console.WriteLine("Tryk 3. for at ændre password");
                Console.WriteLine("Tryk Q. for at afslutte programmet");
               
                ConsoleKeyInfo readKeyResult = Console.ReadKey(true);

                var fodbold = new Fodbold_class();
                var dans = new Dans_class();
                var ændrer = new Password_class();

               if (readKeyResult.Key == ConsoleKey.D1)

                    fodbold.Fodbolden();

                else if (readKeyResult.Key == ConsoleKey.D2)

                    dans.Danse();

                else if (readKeyResult.Key == ConsoleKey.D3)

                    password.Ændre();

                else if (readKeyResult.Key == ConsoleKey.Q)
                    return;

                else
                {
                    Console.WriteLine("\nUgyldigt tegn");
                    Thread.Sleep(1500);
                }

            } while (true);

            
        }
    }
}
