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

            //string input = "";
            do
            { 
                Console.Clear();
                Console.WriteLine("Velkommen til vores PROGRAM OF DOOM! \n");
                Console.WriteLine("Her kan du vælge hvilket program du vil kører. \n");
                Console.WriteLine("Tryk 1. for Fodbold");
                Console.WriteLine("Tryk 2. for Dans");
                Console.WriteLine("Tryk 3. for Password");
                Console.WriteLine("Tryk Q. for at afslutte");
                //int input; while (!int.TryParse(Console.ReadLine(), out input)) Console.WriteLine("Du skal kun bruge tal, tumpe!");
                // input = Console.ReadLine();
                // ConsoleKeyInfo key = Console.ReadKey();
                ConsoleKeyInfo readKeyResult = Console.ReadKey(true);



                var fodbold = new Fodbold_class();
                var dans = new Dans_class();
                var ændrer = new Password_class();


               // if (input == "1")

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
