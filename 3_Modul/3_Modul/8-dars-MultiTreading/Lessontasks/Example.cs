namespace _3_Modul._8_dars_MultiTreading.Lessontasks
{
    public class Example
    {
        public  void FirstThread()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("My thread ");
            }
        }
    }
    public class Sample
    {
        public static void Run()
        {
           Example example=new Example();
           Thread thread = new Thread(new ThreadStart(example.FirstThread));
            thread.Start();
            Console.Read();
            Console.ReadKey();
        }
    }
}
