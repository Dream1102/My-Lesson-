using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._2_Dars.LessonTasks
{
    internal class Subscriber
    {
        List<(object,string)> GetAllMessages =new();

        public void ShowAllMessages()
        {
            foreach(var item in GetAllMessages)
            {
                Console.WriteLine(item);
            }
        }

        public void OnClickSendSms(object sender, string smstext)
        {
            GetAllMessages.Add((sender, smstext));
        }

        internal void SendsmsMessage()
        {

        }
    }
}
