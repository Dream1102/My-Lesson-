namespace Asynchrounos
{
    public class Program
    {
        static async void Main(string[] args)
        {

            TaskExample taskExample = new TaskExample();
            taskExample.Run().ToString();

        }
    }

}
