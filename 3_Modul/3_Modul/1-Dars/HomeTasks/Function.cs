using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars.HomeTasks
{
    internal class Function
    {
        public static void FunctionStart() {
            Func<string, int> fanction = str => str.Length;
            Console.WriteLine(fanction("Salom Dunyo Hayr Bolalik "));
        }
    }
}
