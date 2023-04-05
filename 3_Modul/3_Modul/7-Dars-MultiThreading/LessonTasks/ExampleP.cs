namespace _3_Modul._7_Dars_MultiThreading.LessonTasks
{
    public class ExampleP
    {
        public static void LockSyncThreads()
        {
            int x = 0;
            object locker = new object();
            for (int i = 1; i < 6; i++)
            {
                Thread thread = new(Print);
                thread.Name = $"Qism -> {i}";
                thread.Start();
            }

            void Print()
            {
                lock (locker)
                {
                    x = 1;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name} ->:{x}");
                        x++;
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
