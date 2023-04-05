using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson10_OOP_Introduction.LEssonTasks
{
    internal class FunctionExample
    {

        public static string message = "Hello I am Donald Tramp. Time: " + DateTime.Now;
        public static void Run()
        {
            Func<int, bool> smsSenderPointer = phone =>
            {
                Console.WriteLine("Sms message:'{0}' Phone number:'{1}'", message, phone);
                return true;
            };
            bool result = smsSenderPointer(901112233);
            Console.WriteLine("bool: " + result);
            Func<string> smsSenderPointer1 = () =>
            {
                return "haqiqattan ham ortiq kocheniskiii";
            };

            Console.WriteLine(smsSenderPointer1());
        }

    }
}
