using Domen.Enums;
using Domen.Models;
using Infrastructure;
using Newtonsoft.Json.Linq;

namespace PatientsTurnList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object obj = a;
            Console.WriteLine(obj);
            object b = 11;
            int c = (int)b;
            Console.WriteLine(c.GetType);
        }
    }
}