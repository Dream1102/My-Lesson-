using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._3_Dars.LessonTasks.OqTepaLavsh
{
    internal class Curyer
    {
        public void Task(object? sender , EventHandler e)
        {
            Console.WriteLine("Curyer is runned !");
            e.Invoke(sender, new EventArgs());
            

        
        }
    }
}
