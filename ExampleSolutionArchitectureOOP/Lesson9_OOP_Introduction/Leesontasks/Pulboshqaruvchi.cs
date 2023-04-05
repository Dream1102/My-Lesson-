using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson9_OOP_Introduction.Leesontasks
{
    internal class Pulboshqaruvchi
    {

        public void Uzs2usd(Pul pul)
        {
            pul.Valyuta = "USD";
            pul.Miqdor /= 11000;
        }

        public void Usd2uzs(Pul pul)
        {
            pul.Valyuta = "UZS";
            pul.Miqdor *= 11000;
        }

        public void Yuborish(Pul pul, string bank, Pul.PulDelegati delegat)
        {
            if (delegat.Target != null)
                delegat(pul);

            Console.WriteLine(pul.Miqdor.ToString("0,00") + pul.Valyuta + " miqdordagi pul " + bank + " bankiga muvafaqiyatli yuborildi ");
        }
    }
}
