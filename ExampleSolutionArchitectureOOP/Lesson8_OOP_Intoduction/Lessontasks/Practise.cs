using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson8_OOP_Intoduction.Hometasks
{
    internal class Practise
    {
        public void Do()
        {
            List<string> list = new List<string>();
            list.Add("Pizza");
            list.Add("Hamburger");
            list.Add("Lavash");
            list.Add("Fries");
            list.Add("Pishloq");
            list.Add("Somsa");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
