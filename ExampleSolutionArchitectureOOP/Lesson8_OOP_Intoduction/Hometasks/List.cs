using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson8_OOP_Intoduction.Hometasks
{
    internal class List
    {

        public void Liststart1()
        {
            List<int> list = new List<int>();
            list.Add(12);
            list.Add(3);
            list.Add(34);
            list.Add(56);
            list.Add(11);
            list.Add(32);
            list.Add(45);
            list.Add(111);
            list.Add(43);
            int maxx = 0;
            foreach (int i in list)
            {
                if (i > maxx & i % 2 == 0)
                    maxx = i;

            }
            Console.WriteLine(maxx);
        }

        public void Liststart2()
        {
            List<int> lis = new List<int>();
            lis.Add(1);
            lis.Add(2);
            lis.Add(3);
            lis.Add(4);
            lis.Add(4);
            lis.Add(5);
            lis.Add(6);
            for (int index = 1; index < lis.Count; index++)
            {
                if (lis[index - 1] == lis[index])
                {
                    Console.WriteLine((index + 1) + " Bo'lishi kerak edi hato yozdik " + index + " deb hato yodik");
                }

            }
        }
        public void Listart3()
        {

        }
        public void Liststart4()
        {
            List<string> list = new List<string>();
            list.Add("Salim");
            list.Add("Davron");
            list.Add("Bahrom");
            list.Add("Abbos");
            list.Add("Javlon");
            list.Add("Borburi");
            list.Add("Sarvar");
            list.Add("Diyor");
            list.Add("Ganisher");
            list.Add("Abdulatif");
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i][0] != 'A')
                {
                    Console.WriteLine(list[i] + " ");
                }
            }
        }
    }
}

