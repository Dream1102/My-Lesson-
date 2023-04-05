using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._11_Dars_Linq_2Example.HomeTask
{
    public class HomeTAsk17Talik
    {
        public static void Misol()
        {
            Task3();
        }
        public static void Task1()
        {
            int[] numbers = new int[] { 67, 92, 153, 15 };

            var MethodSyntax = numbers.Where(x => x > 30 && x < 100).ToList();
            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item);
            }
        }
        public static void Task2()
        {
            string[] words = { "Laptop","Keyboard","Mouse","Phone","Ali"};

            IEnumerable<string> result = words.Where(r => r.Length >= 5).Select(r => r.ToUpper());

            foreach (var item in result)
            {
                Console.WriteLine( item);
            }
        }
        public static void Task3()
        {
            string[] words = new string[] { "mum", "amsterdam", "bloom", "amsterdam" };

            char StarChar = 'a';
            char EndChar = 'm';

            var result = words.FirstOrDefault(sity => sity.StartsWith(StarChar) && sity.EndsWith(EndChar));

            Console.WriteLine(result);

        }
    }
}
