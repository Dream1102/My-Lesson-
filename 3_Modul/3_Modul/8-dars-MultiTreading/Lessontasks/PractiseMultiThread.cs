using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._8_dars_MultiTreading.Lessontasks
{
    public static class PractiseMultiThread
    {
        public static void Run()
        {
            
        }
        static void ThreadProperties()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Main_Thread";
            Console.WriteLine($"Potok ismi :{thread.Name}");
            Console.WriteLine(thread.IsAlive);
            Console.WriteLine($"Potok ID :{thread.ManagedThreadId}");
            Console.WriteLine($"Ishlabdimi yo'g'mi shuni bilish uchun :{thread.ThreadState}");
            Console.WriteLine($"Uning darjasi yoki Fe'lini bilish uchun :{thread.Priority}");
            thread.Interrupt();
           
            Console.WriteLine(Thread.GetDomain);
            Console.WriteLine(Thread.GetDomainID);
        }
        static void Javoh()
        {
            int x = 0;
            for (int i = 1; i < 3; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Potok : {i}"; 
                myThread.Start();
            }

            void Print()
            {
                x = 1;
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} -> {x}");
                    x++;
                   Thread.Sleep(1000);
                }
            }
        }
    }
}
