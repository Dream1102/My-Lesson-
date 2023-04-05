using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3_Modul._3_Dars.Hometaks
{
    internal class Task2
    {
        public static void Satr()
        {
            Console.Write("Matnni kiriting :");
            
            string str=Console.ReadLine() ?? "Hello 12345 $world, hi eve/???'}{ryone 981askmdfl1213";
            Console.WriteLine(str);
            for(int i=0;i<str.Length;i++)
            {

                str = Regex.Replace(str, "[ -/:-~]", "");
            }
            Console.WriteLine(str);
        }
    }
}
