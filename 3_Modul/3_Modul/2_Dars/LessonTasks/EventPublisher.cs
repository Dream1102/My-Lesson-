namespace _3_Modul._2_Dars.LessonTasks
{
    delegate void ClickSendSms(object? sender, string smstext);
   internal  class EventPublisher
    {
        public event ClickSendSms? OnClickSendSms;

        public  void SendSmsMessage()
        {
            Console.Write("Xabarni kiriting :");

            string sms = Console.ReadLine() ?? "No text";

            OnClickSendSms?.Invoke(this, sms);
        }

         internal void ShowAllMessage()
          {

          }
    }

}
