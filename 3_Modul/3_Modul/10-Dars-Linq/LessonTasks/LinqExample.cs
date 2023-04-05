using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._10_Dars_Linq.LessonTasks
{
    public class LinqExample
    {
        public static void Run()
        {
            #region 1_Misol
            /*
            var employees = Employee.GetEmployees();
            var result = from e in employees
                         where e.Salary > 80000
                         orderby e.LastName ascending
                         select new { FullName = e.FirstName + " " + e.LastName, e.Salary };
            foreach (var r in result)
            {
                Console.WriteLine("{0,-20} {1:C}", r.FullName, r.Salary);
            }*/
            #endregion


            // Xodimlar ro'yxati olinadi
            List<Employee> employees = Employee.GetEmployees();

            // Faqat IT bo'limida ishlaydigan xodimlar saralash
            var itEmployees = employees.Where(e => e.Department == "IT").OrderBy(e => e.LastName).ThenBy(e => e.FirstName);

            Console.WriteLine("IT bo'limida ishlaydigan xodimlar:");
            foreach (var e in itEmployees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} - {e.Salary}");
            }

            // Xodimlarni barcha bo'limlari bo'yicha saralash
            var allEmployees = employees.OrderBy(e => e.Department).ThenBy(e => e.LastName).ThenBy(e => e.FirstName);

            Console.WriteLine("\nHamma xodimlar bo'limlari bo'yicha saralgan:");
            foreach (var e in allEmployees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} - {e.Department} - {e.Salary}");
            }

            // Bo'limlar bo'yicha xodimlar soni hisoblanadi
            var employeeCountByDepartment = employees.GroupBy(e => e.Department).Select(g => new { Department = g.Key, Count = g.Count()});

            Console.WriteLine("\nBo'limlar bo'yicha xodimlar soni:");
            foreach (var e in employeeCountByDepartment)
            {
                Console.WriteLine($"{e.Department} - {e.Count}");
            }

            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
            new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000, Department = "IT" },
            new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000, Department = "Finance" },
            new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000, Department = "IT" },
            new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000, Department = "HR" },
            new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000, Department = "IT" },
            new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000, Department = "Finance" }
            };
            return employees;
        }

        public class EmployeeBasicInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Salary { get; set; }
        }
    }
}
