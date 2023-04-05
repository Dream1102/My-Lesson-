using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._3_Dars.LessonTasks.OqTepaLavsh
{
    internal class Boss
    {
        public event EventHandler<EventHandler> Order;

        EventHandler? BossOrder;
       
        public void Start()
        {
            Customer customer = new(); 

            BossOrder += customer.Method1;
            BossOrder += customer.Method2;
            BossOrder += customer.Method3;
            BossOrder += customer.Method4;
            BossOrder += customer.Method5;

            Order.Invoke(this, BossOrder);

        }
    }
}
