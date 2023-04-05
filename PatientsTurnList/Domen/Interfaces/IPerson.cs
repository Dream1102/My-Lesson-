using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen.Enums;

namespace Domen.Interfaces
{
    public  interface IPerson
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Gender  Gender { get; set; }
        public DateTime BirthDate{ get; set; }
    }
}
