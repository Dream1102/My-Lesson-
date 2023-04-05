namespace _3_Modul._9_Dars_Asycrouns.Lessontasks
{
    public class TaskExample
    {
        public static void Runner()
        {
              Console.WriteLine("Main thread starting.");

            // Create a new task
            Task task = new Task(() =>
            {
                Console.WriteLine("Task starting.");
                // Perform some long-running operation
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Task running {i}");
                    Task.Delay(1000).Wait();
                }
                Console.WriteLine("Task completed.");
            });

            // Start the task
            task.Start();

            Console.WriteLine("Main thread continuing.");

            // Wait for the task to complete
            task.Wait();

            Console.WriteLine("Main thread completed.");
        }
    }

}

