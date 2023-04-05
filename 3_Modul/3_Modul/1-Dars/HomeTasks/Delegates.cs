using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars.HomeTasks
{
   
   public static class Delegates
    {
        public delegate string WithParametrs(string name1, string name2);

        public static void Run()
        {
            WithParametrs withParam = new(ShowMessage);

            string value = withParam("John", "Nick");

            Console.WriteLine(value);

            Console.ReadLine();
        }

        public static string ShowMessage(string name1, string name2)
        {
            Console.WriteLine($"{name1},{name2} Beutiful Uzb!");

            return "Pdp Academy";
        }
       
    }
}
