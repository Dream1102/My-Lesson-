namespace ExampleSolutionArchitectureOOP._2_Dars
{
     public class Algebra
    {
        public int Add(int a, int b)
        { return a + b; }
        public int Add(int a,int b,int c)
        {
                return a + b + c;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           Algebra algebra = new Algebra();
            Console.WriteLine( algebra.Add(1, 2));
            Console.WriteLine(algebra.Add(1,2, 3));
        }
        
    }
}
