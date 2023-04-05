using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitectureOOP._1_Dars.LessonTask
{
    public  class Person
    {
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set { _name = value; }
         
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 &&  value < 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Bunaqa odam hayotda yo'q !");
                }
            }
        }
        
        public void GetInformation()
        {
            Console.WriteLine($"{_name} is {_age} years old");
        }
    }
}
