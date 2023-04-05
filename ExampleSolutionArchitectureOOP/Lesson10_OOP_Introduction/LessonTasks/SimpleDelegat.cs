using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson10_OOP_Introduction.LessonTasks
{
    public static class SimpleDelegat
    {
        public delegate void Del(string message);

        public static void DelegatMethod(string message)
        {
            Console.WriteLine(message);

            Del handler = DelegatMethod;
            handler("Hello World!");
        }

    }
}
