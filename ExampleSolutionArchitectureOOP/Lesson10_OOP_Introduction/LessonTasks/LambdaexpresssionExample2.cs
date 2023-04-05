using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson10_OOP_Introduction.LEssonTasks
{
    internal class LambdaexpresssionExample2
    {
        public static string message = "Hello I am Ortiq :" + DateTime.Now;
        public delegate bool SmsServisPointer(int number);

        public static void Run()
        {
            SmsServisPointer smsServisPointer = phone =>
            {
                Console.WriteLine("Sms message :", message, phone);
                return true;
            };

            bool result = smsServisPointer(933521102);
            Console.WriteLine("Email message:{0} was sent to ortiq@gmail.com", message);
        }
    }
}
