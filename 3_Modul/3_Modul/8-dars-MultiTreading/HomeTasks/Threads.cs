namespace _3_Modul._8_dars_MultiTreading.HomeTasks
{
    public class Threads
    {
        public static void Run()
        {
            Thread MyThread = Thread.CurrentThread;
            MyThread.Name = "MyThread";
         

            Thread thread1 = new Thread(() => CountDown("Timer 1#"));
            Thread thread2 = new Thread(() => CountUP("Timer 2#"));
            thread1.Start();
            thread2.Start();

            Console.ReadKey();

            Console.WriteLine(MyThread.Name +" is coplete !");

        }

        public static void CountDown(string name)
        {
            for(int i=10;i>=0;i--)
            {
                Console.WriteLine("Timer 1# :"+i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 1# is completed !");
        }
        public static void CountUP(string name)
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("Timer 2# :"+i+" seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 2# is completed !");
        }
    }
}
