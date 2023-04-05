using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._8_dars_MultiTreading.Lessontasks
{
    public class MultiThread
    {
        public static void Runner()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "MyThread";


            Thread thread1 = new Thread(() => CountDown("Timer 1#"));
            Thread thread2= new Thread(() => CountUP("Timer 2#"));
            thread1.Start();
            thread2.Start();


            
            Console.WriteLine(thread.Name + " is completed !");
            Console.ReadKey();
        }

       public static void CountDown(string name)
        {
            for(int i=10;i>=0;i--)
            {
                Console.WriteLine("Timer #1 : "+i+" seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 1# is completed !");
        }

        public static void CountUP(string name)
        {
            for (int i =0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 2# is completed !");
        }
    }
}
