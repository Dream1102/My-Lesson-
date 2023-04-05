using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen.Enums;
using Domen.Interfaces;

namespace Domen.Models
{
    public class Doctor : IDoctor
    {
        public Speiciality Speciality { get ; set ; }
        public int ExperienceTime { get ; set ; }
        public Guid ID { get ; set ; }
        public string Name { get ; set ; }
        public string Address { get ; set ; }
        public int Age { get ; set ; }
        public Gender Gender { get ; set ; }
        public DateTime BirthDate { get ; set ; }
        public int WorkTime { get ; set ; }
    }
}
