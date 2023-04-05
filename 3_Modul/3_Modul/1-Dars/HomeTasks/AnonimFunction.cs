using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars.HomeTasks
{
    internal class AnonimFunction
    {
        public delegate string anonimFunction1(int x,  string y);
        public delegate int anonimFunction2(int x, string y);
        public delegate bool anonimFunction3(int x, int y);

        public static void AnonimFunctionStart()
        {
            anonimFunction1 anonim1 = delegate (int x, string y)
            {
                 return y.Substring(x, y.Length - x);
            };
            Console.WriteLine(anonim1(4,"O'zbekiston buyuk davlat !"));

            anonimFunction2 anonim2 = delegate (int x, string y)
            {
                return (y.Length - x);
            };
            Console.WriteLine(anonim2(5,"O'zbekistonni alishmam boshqa jahonga !"));

            anonimFunction3 anonim3 = delegate (int x, int y)
            {
                 if (x > y)
                
                    return true;
                
                else
                
                    return false;
                
            };

            Console.WriteLine(anonim3(6,7));
        }
        
    }
}
