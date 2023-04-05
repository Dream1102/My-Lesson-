namespace ExampleSolutionArchitecture.Lesson9_OOP_Introduction.Hometasks
{
    public static class Tupple
    {
        public static void Tapple()
        {
            (double, int) t = (3.4, 7);
            var b = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            (string, double) k = ("Hello world :", 78.9);
            Console.WriteLine(t);
            Console.WriteLine(b);
            Console.WriteLine(k);
            int? h = null;
            Console.WriteLine(h);
            int? f = 5;
            Console.WriteLine(f.Value);
            int? a = null;
            if (a is int valueOfA)
            {
                Console.WriteLine($"a is {valueOfA}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }
            // Output: is null::::-> null
            int? j = 10;
            if (j.HasValue)
            {
                Console.WriteLine($"j is {j.Value}");
            }
            else
            {
                Console.WriteLine("b does not have a value");
            }
            int? c = 123456789;
            c = null;
            if (c != null)
            {
                Console.WriteLine($"C is ->{c.Value}");
            }
            else
                Console.WriteLine("C doesn't have value !");

            int? m = 28;
            int n = m ?? -1;
            Console.WriteLine($"b is {b}");  // output: n is 28

            int? v = null;
            int x = v ?? -1;
            Console.WriteLine($"d is {x}");  // output: x is -1
        }

    }
}
