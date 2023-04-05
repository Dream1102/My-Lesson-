using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._2_Dars.Hometaks
{
    internal class OnEvenNumber
    {
        public EventHandler<EventArgs> OnEvenNumberFound = delegate { };

        private List<int>? _list;

        public List<int> ListOfElement
        { 
          set
            {
                int a=value.Find(a => a%2 ==0);
                
                if(a>0)
                {
                    OnEvenNumberFound.Invoke(this, new EventArgs());
                }
            }
        }

    }
}
