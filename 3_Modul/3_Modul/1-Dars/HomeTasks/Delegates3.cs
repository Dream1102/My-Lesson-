using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars.HomeTasks
{
    public static class Delegates3
    {
        public delegate string Bar(string name, string place);

        public static void Run()
        {
            Bar bar = new(ShoU);
            string value = bar("Bla bla bar", "Toshkent");
            Console.WriteLine(value);
        }

        public static string ShoU(string name, string place)
        {
            Console.WriteLine("Bar is opened ...");
            Console.WriteLine($"{name} {place}");

            return "Bar ";
        }
    }
}
