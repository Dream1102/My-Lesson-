using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson9_OOP_Introduction.Leesontasks
{
    internal class Pul
    {
        public double Miqdor { get; set; } // Pul miqdori
        public string Valyuta { get; set; } //Valyuta turi

        public Pul(double miqdor)
        {
            Miqdor = miqdor;
            Valyuta = "UZS";
        }

        public delegate void PulDelegati(Pul pul);
    }
}
