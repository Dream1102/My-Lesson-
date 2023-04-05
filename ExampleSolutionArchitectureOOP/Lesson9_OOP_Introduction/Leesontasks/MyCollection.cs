using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitecture.Lesson9_OOP_Introduction.Leesontasks
{
    internal class MyCollection<T>
    {
        public List<T> list = new();
        public T TValue { get; set; }
        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }
        public void Addvalue(T value)
        {
            list.Add(value);
        }
        public void ContainsValue(T value)
        {
            list.Contains(value);
        }
    }
}
