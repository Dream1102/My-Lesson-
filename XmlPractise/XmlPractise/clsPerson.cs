using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlPractise
{
    public class clsPerson
    {
        public string FirstName;
        public string MI;
        public string LastName;
    }
    class class1
    {
        static void Main(string[] args)
        {
            clsPerson p= new clsPerson();
            p.FirstName = "Jerry";
            p.MI = "T";
            p.LastName = "Price";

            System.Xml.Serialization.XmlSerializer x= new System.Xml.Serialization.XmlSerializer(p.GetType());
            x.Serialize(Console.Out, p);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
