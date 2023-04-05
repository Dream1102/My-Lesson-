using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson10_OOP_Introduction.LEssonTasks
{
    public static class ActionExample
    {
        public static void Run()
        {
            Action<string> PrintConsoleAction = message => Console.WriteLine(message);
            PrintConsoleAction("action amalda ishlash tarzda !");

            Action<int> console = phone => Console.WriteLine(phone);
            console(933521102);

            Action<double> sasay = math => Console.WriteLine(math);
            sasay(3.14091);

            Action<int> dodor = alish => Console.WriteLine(alish);
            dodor(364702553);

            Action ortiq = () => Console.WriteLine("Ortiq kocheniski:");
            ortiq();

            Func<string> smsSenderPointer1 = () =>
            {
                return "haqiqattan ham ortiq kocheniskiii";
            };

            Console.WriteLine(smsSenderPointer1());

        }
    }
}
