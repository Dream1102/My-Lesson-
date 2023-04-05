namespace ExampleSolutionArchitectureOOP._2_Dars
{
    public class Time
    {
        // 1. Quyidagi 3ta field'larga ega bo’lgan Time klassini encapsulation prinsipi asosida yarating: 
        //soat, minut, va sekund. “soat:minut:sekund” (Masalan: 01:25:08) formatdagi vaqtni qaytaruvchi
        //metod yarating. (oson)

        private int _hour;
        private int _minute;
        private int _second;

        public int Hour
        {
            get
            {
                return _hour;
            }
            set { if (value > 0) _hour = value; }
        }
        public int Minute
        {
            get { return _minute; }
            set { if (value > 0) _minute = value; }
        }
        public int Second
        {
            get { return _second; }
            set
            {
                if (value > 0) _second = value;
            }
        }
        //public void GetTimeInformation()
        //{
        //    Console.WriteLine($"{Hour}:{Minute}:{Second}");
        //}
    }
}
   

