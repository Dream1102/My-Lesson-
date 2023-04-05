using System.Text.RegularExpressions;

namespace _3_Modul._9_Dars_Asycrouns.Lessontasks
{
    public class Asynchrounous
    {
        public static void Run()
        {
            Console.WriteLine("Main Method Started......");

            var res = AddAsyn(10, 20);
            Console.WriteLine(res.Result);

            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }
          
        public static async Task<int> AddAsyn(int a, int b)
        {
            Console.WriteLine("Task is started :");

            await Task.Delay(TimeSpan.FromSeconds(5));

            Console.WriteLine("Task is finished !");

            return a * b;
        }
        public static async Task<string> SomeMethod()
        {
            Console.WriteLine("Some Method Started......");

            await Task.Delay(TimeSpan.FromSeconds(10));
            
            Console.WriteLine("Some Method End");

            return "Hello Task";

        }

        public static void CountDown()
        {
            for(int i=10;i>=0;i--)
            {
                Console.WriteLine("Timer 1# :" + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 1# is completed !");
        }
        public static void CountUp()
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("Timer 2# :"+i+" seconds");
            }
            Console.WriteLine("Timer 2# completed");
        }
    }

}

