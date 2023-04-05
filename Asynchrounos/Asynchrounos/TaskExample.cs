using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchrounos
{
    public class TaskExample
    {
        public async Task Run()
        {
            Console.WriteLine("Run start !");

          //await AsynTask();
          //await MyTask();

          //  Console.WriteLine("Run stopped :");

          //  Console.ReadKey();
        }

        public async Task AsynTask()
        {
            Console.WriteLine("AsynTask start");

            await Task.Delay(3000);
            Console.WriteLine("AsynTask stopped !");
        }
        Task MyTask()
        {
            Console.WriteLine("MyTask start ...");
            Task result = new(() =>
            {
                Task.Delay(10000);
                Console.WriteLine("MyTask stopped ...");
            });
            return Task.CompletedTask;
        } 
    }
}
