namespace _3_Modul._11_Dars_Linq_2Example.LessonTasks
{
    internal class SimpleExample
    {
        public static void Simple()
        {
            Example10();
        }
        public static void Example1()
        {
            //Bu ma'lumotlar manbayi string massiv 
            string[] names = { "Ortiq", "ahmadullo", "Sevar", "aziz" };

            // LINQ so'rovi 

            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // So'rovni ishlatish 

            foreach (var name in myLinqQuery)

                Console.WriteLine(name + " ");
            Console.ReadKey();
        }
        public static void Example2()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var myLinqQuery = from number in numbers
                              where number % 2 == 0
                              select number;

            foreach (var item in myLinqQuery)
            {
                Console.WriteLine(item);
            }
        }
        public static void Example3()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var myLinq = from number in numbers
                         where number % 2 == 1
                         select number;
            foreach (var item in myLinq)
            {
                Console.WriteLine(item);
            }
        }
        public static void Example4()
        {
            int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var LinqNumber = from numbers in number
                             where numbers % 2 == 1
                             select numbers;
            foreach (var item in LinqNumber)
            {
                Console.WriteLine(item);
            }
        }
        public static void Example5()
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            IEnumerable<int> scoreQuery = from score in scores
                                          where score > 80
                                          select score;
            foreach (var item in scoreQuery)
                Console.WriteLine(item);
        }
        public static void Example6()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var myQuery = from obj in numbers
                          where obj > 2
                          select obj;
            foreach (var item in myQuery)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("#____________#___________#___________#");

            var methodSyntax = numbers.Where(obj => obj > 2);

            foreach (var item in methodSyntax)
                Console.WriteLine(item);

            Console.WriteLine("#____________#____________#___________#");

            var mixedSyntax = (from obj in numbers
                               select obj).Max(obj => obj);
            Console.WriteLine("Max value :" + mixedSyntax);

        }
        public static void Example7()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var score = from obj in list
                        where obj > 2 & obj < 10
                        select obj * 2;
            foreach (var item in score) Console.WriteLine(item + " ");
            Console.WriteLine("\n");

            var MethodSynatx = list.Where(obj => obj > 5);

            foreach (var item in MethodSynatx) Console.WriteLine(item + " ");

            Console.WriteLine("\n");

            var mixedSytax = (from  obj in list
                             select obj).Min();
               Console.WriteLine(mixedSytax+" ");
            
        } 
        public static void Example8()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Shodiyor"},
                new Employee(){ Id = 2,Name = "Ortiq"}
            };

            IEnumerable<Employee> query = from emp in employees
                                          where emp.Id == 1 || emp.Id==2
                                          select emp;
            
            foreach (var item in query)
            {
                Console.WriteLine($"Id = {item.Id} Name: {item.Name}");
            }
        
    } 
        public static void Example9()
        {
            List<Employee> employees = new List<Employee>()
            { 
                new Employee(){ Id = 1,Name = "Ortiq"},
                new Employee(){ Id = 2,Name ="Diyorbek"}
            };
            IQueryable<Employee> query =employees.AsQueryable().Where(x => x.Id==1);
            foreach (var item in query)
            {
                Console.WriteLine($"Id  :{item.Id} Name :{item.Name}");
            }
        }
        public static void Example10()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var res = from number in numbers
                      where Math.Pow(number, 2) > 25
                      select new 
                      {
                         Number = number,
                         SqrNo=Math.Pow(number,2),
                      };
            foreach(var item in res)
            {
                Console.WriteLine($"Number :{item.Number} : SqrNo :{item.SqrNo}");
            }
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

