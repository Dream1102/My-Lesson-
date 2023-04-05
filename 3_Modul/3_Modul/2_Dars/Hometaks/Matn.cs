namespace _3_Modul._2_Dars.Hometaks
{
    internal static class Matn
    {
        public static void StringLEngth()
        {
            Console.WriteLine("Satrni kiriting :");
            string satr = Console.ReadLine();
            
            try
            {
                if (satr == "")
                {
                    throw new ArgumentException();
                }
                else
                {
                    Console.WriteLine(satr.Length);
                }
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message + "\nKiritilgan matn bo’sh bo’lmasligi kerak");
            }
        }
    }
}
