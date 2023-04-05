using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._9_Dars_Asycrouns.Lessontasks
{
    internal class Example
    {
        public async Task Run()
        {
            Console.WriteLine("Run start");
            Task<int> resSoliq = SenderSoliq("550000");
            Task<string> res= SenderIIB("5555");

            

            Console.WriteLine("Run stop");

            Console.WriteLine(res.Result);
            Console.WriteLine(resSoliq.Result);
           
            Console.ReadKey();
        }
         async Task<string> SenderIIB(string a)
        {
            Task<string> junat = new(() =>
            {
                Task.Delay(20000).Wait();
                Console.WriteLine("So'rov junatildi");
                Task.Delay(3000);
                return $"{a}5555";
            });
            junat.Start();
            Console.WriteLine("Yuborildi...");
            return "5555";
        }
        async Task<int> SenderSoliq(string PassportID)
        {
            Task<int> yuborish = new(() =>
            {
                Task.Delay(1000).Wait();
               // Console.WriteLine("So'rov Junatildi ...");
                Task.Delay(5000);
                return 55555;
            });
            yuborish.Start();

            Console.WriteLine("Yuborildi ..");
            return await yuborish;
        }
    }
}
