using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars.HomeTasks
{
    internal class Delegates2
    {
        public delegate void NoParametrs();

        public static void Run()
        {
            NoParametrs noPrm = new(ShowMessage1);
            noPrm += ShowMessage2;
            noPrm();

            Console.ReadLine();
        }
        public static void ShowMessage1() => Console.WriteLine($"Have Fun Bro !");
        public static void ShowMessage2() => Console.WriteLine($"See you Bro !");

    }
}
