using Logic_and_Classlibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Basis_programmering
{
    internal class Password_class:Password_lib
    {

        public void Passwordet()
        {

            var password = new Password_lib();

            if (new FileInfo(@"C:\Users\davfro\Desktop\bruger\bruger.txt").Length == 2)
            {
                password.Opret();
            }
            else
            {
                password.Login();
            }
        }
           public void skift()
            {

                var ændrer = new Password_lib();

                ændrer.Ændre();


            }

           

            













            // https://www.c-sharpcorner.com/UploadFile/jitendra1987/password-validator-in-C-Sharp/

            // https://www.codeproject.com/Questions/5349461/How-do-I-save-read-write-to-file
        
        
        
        
        
        
        
        
        



    }
}
