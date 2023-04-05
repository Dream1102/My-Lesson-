using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson10_OOP_Introduction.Hometasks
{
    internal class Misol2
    {
        public delegate (int, int) MinMaxDelegate(List<int> list);

        public (int, int) UseDelegate(List<int> list)
        {
            var a = (max: list.Max(), min: list.Min());

            return a;
        }
        public void Run()
        {
            MinMaxDelegate del = UseDelegate;
            var a = del.Invoke(new List<int>() { 5, 68, 22, -64, 33, 48, 24 });
            Console.WriteLine($"Max: {a.Item1}\nMin: {a.Item2}");
        }
    }
}
