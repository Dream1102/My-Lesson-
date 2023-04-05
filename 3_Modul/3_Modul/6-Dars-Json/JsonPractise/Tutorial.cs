using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._6_Dars_Json.JsonPractise
{
    public class Tutorial
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string[] Tags { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Description}-{Url}-{string.Join(",",Tags)}";   
        }
    }
}
