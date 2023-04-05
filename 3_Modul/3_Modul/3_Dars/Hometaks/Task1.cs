using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Modul._3_Dars.Hometaks
{
    internal class Task1
    {
        public static void Names()
        {
          //  string[] names = { "Ortiq", "Sardor", "Abdulatif", "Diyorbek", "Jaxon", "Elyor","Sarvar" };

            List<string> names = new List<string>()
            {
                 "Ortiq", "Sardor", "Abdulatif", "Diyorbek", "Jaxon", "Elyor","Sarvar","Salim"
            };    
             names.RemoveAll(name => !(Regex.IsMatch(name, "^S")));
             foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            //    names.ForEach(name => Console.WriteLine(name));
                /*  foreach (string name in names)
                  {
                      if (IsRegexName(name))
                      {
                          Console.WriteLine(name);
                      }
                      else
                      { Console.WriteLine("Topilmadi !"); }


                  }
                  static bool IsRegexName(string name)
                  {
                      string pattern = @"^[A-Z]{1}[a-z]+$";

                      return Regex.IsMatch(name, pattern);
                  }*/
            }
    }
}
