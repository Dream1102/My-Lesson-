using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._3_Dars.Hometaks.Agent007
{
    internal class Bossse
    {
        public event EventHandler<Human> BossOrder;
        public void SendOrder(Human human)
        {
            BossOrder.Invoke(this, human);
        }
    }
}
