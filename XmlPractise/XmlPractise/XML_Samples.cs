using System.Xml;
using System.Xml.Serialization;

namespace XmlPractise
{
    internal class XML_Samples
    {
        static readonly string XMLFile1 = @"..\..\..\XMLFile1.xml";
        static readonly string XMLFile2 = @"..\..\..\XMLFile2.xml";
        public static void Run()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLFile1);

            XmlElement? xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
               
                foreach (XmlElement xnode in xRoot)
                {
                    
                    XmlNode? attr = xnode.Attributes.GetNamedItem("name");
                    Console.WriteLine(attr?.Value);

                    
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                       
                        if (childnode.Name == "company")
                        {
                            Console.WriteLine($"Company: {childnode.InnerText}");
                        }
                        
                        if (childnode.Name == "age")
                        {
                            Console.WriteLine($"Age: {childnode.InnerText}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
    
        public static void XML_Serialize()
        {
            Person person = new Person("Tom", 37);

          
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

          
            using (FileStream fs = new(XMLFile2, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, person);

                Console.WriteLine("Object has been serialized");
            }        
            using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
        {
            Person person1 = (Person)xmlSerializer.Deserialize(fs) ?? new();
            Console.WriteLine($"Name: {person1?.Name}  Age: {person1?.Age}");
        }
    }
    }
    public class Person
    {

        public string Name { get; set; } = "Undefined";
        public int Age { get; set; } = 1;

        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }


}

