using _3_Modul._3_Dars.LessonTasks.OqTepaLavsh;

namespace _3_Modul._3_Dars
{
    internal class StartUps
    {
        public static void MainRegex()
        {
            //Regular1task.Start();


            //  Task1.Names();


            //  Task2.Satr();


            //Human human = new();
            //human.FullName = "Black Negor";
            //human.age = 19;
            //human.isLife = false;
            //Boss boss = new();
            //Killer killer = new();
            //boss.BossOrder += killer.GetOrder;
            //boss.SendOrder(human);
            //Console.WriteLine(human.isLife);
            Boss boss = new();

            Curyer curyer = new Curyer();

            boss.Order += curyer.Task;

            boss.Start();
        }
    }
}
