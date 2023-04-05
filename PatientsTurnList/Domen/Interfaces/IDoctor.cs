using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen.Enums;

namespace Domen.Interfaces
{
    public  interface IDoctor : IPerson
    {
        public Speiciality Speciality { get; set; }

        public int ExperienceTime { get; set; }

        public int WorkTime { get; set; }
    }
}
