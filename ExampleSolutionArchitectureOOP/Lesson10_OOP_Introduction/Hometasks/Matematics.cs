using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson10_OOP_Introduction.Hometasks
{
    internal class Matematics
    {
        private delegate void Matematicsdelegate(int a, int b);

        public void Run()
        {
            Matematicsdelegate kel = Sum;
            kel += Substract;
            kel += Divide;
            kel += Sultiplay;
            kel.Invoke(100, 20);
        }
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Sultiplay(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
