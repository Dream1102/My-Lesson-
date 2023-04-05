namespace ExampleSolutionArchitecture.Lesson9_OOP_Introduction.Hometasks
{
    internal class DictionaryHW
    {
        public void PrintDictionary<T, U>(Dictionary<T, U> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }
            Console.WriteLine();

        }
    }
}
