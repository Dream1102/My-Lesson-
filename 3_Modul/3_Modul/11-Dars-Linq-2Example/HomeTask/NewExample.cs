namespace _3_Modul._11_Dars_Linq_2Example.LessonTasks
{
    public class NewExample
    {
        public static void StartJoin()
        {
            var students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Jasurbek", AddressId = 1},
            new Student() { Id = 2, Name = "Xondamir", AddressId = 1},
            new Student() { Id = 3, Name = "Shoxruh", AddressId = 3},
            new Student() { Id = 4, Name = "Shaxzod", AddressId = 4},
            new Student() { Id = 5, Name = "Abdulloh", AddressId = 2}
        };
            var addresses = new List<Address>()
            {
            new Address() {Id = 1, AddressLine = "Line 1"},
            new Address() {Id = 2, AddressLine = "Line 2"},
            new Address() {Id = 3, AddressLine = "Line 3"},
            new Address() {Id = 4, AddressLine = "Line 4"},
            new Address() {Id = 5, AddressLine = "Line 5"}
        };
            var QuerySyntax = (from student in students
                               join address in addresses
                               on student.AddressId equals address.Id
                               select new
                               {
                                   StudentName = student.Name,
                                   Line = address.AddressLine
                               }).ToList();
            foreach (var item in QuerySyntax)
            {
                Console.WriteLine($"Name: {item.StudentName} \tLine: {item.Line}");
            }
        }
        public class Student
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public int AddressId { get; set; }
        }
        internal class Address
        {
            public int Id { get; set; }
            public string AddressLine { get; set; }
        }
    }
}
