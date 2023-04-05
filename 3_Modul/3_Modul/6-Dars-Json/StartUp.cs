using _3_Modul._6_Dars_Json.JsonPractise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._6_Dars_Json
{
    internal class StartUp
    {
        public static void Run()
        {
            Tutorial tutorial = new Tutorial()
            {
                Name = "C#",
                Description = "C#",
                Url = "I4763265",
                Tags = new string[] { "Salom",
                    "Dunyo", "Pdp" }
            };
            Console.WriteLine(tutorial);
        }

    }
}
