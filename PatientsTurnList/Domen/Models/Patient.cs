using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen.Enums;
using Domen.Interfaces;

namespace Domen.Models
{
    public class Patient : IPatient
    {
        public int TurnNumber { get ; set ; }
        public Guid ID { get ; set ; }
        public string Name { get ; set ; }
        public string Address { get ; set ; }
        public int Age { get ; set ; }
        public Gender Gender { get ; set ; }
        public DateTime BirthDate { get ; set ; }
        public IlnessTypes IlnessType { get  ; set ; }
    }
}
