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
            

            goal = goal.ToLower();

            if (goal != "mål")

            {
                if (afleveringer == 0)
                    Console.WriteLine("Shh");

                if (afleveringer >= 10)
                    Console.WriteLine("*High Five* - Jubel");

                else
                {
                    for (int i = 0; i < afleveringer; i++)
                    {
                        Console.Write("Huh! ");
                    }
                }
            }
            else
                Console.WriteLine("Olé olé olé");

        }
    }
}
