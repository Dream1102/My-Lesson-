using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen.Enums;

namespace Domen.Interfaces
{
    public  interface IPatient : IPerson
    {
        public int TurnNumber { get; set; }

        public IlnessTypes   IlnessType { get; set; }


    }
}
