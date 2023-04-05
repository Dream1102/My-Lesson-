using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._3_Dars.Hometaks.Agent007
{
    internal class Killer
    {
        public void GetOrder(object? obj , Human human)
        {
            human.isLife = false;

            Console.WriteLine($"{human.FullName} is dead ");
        }

    }
}
