using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._11_Dars_Linq_2Example.Groupoin
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { ID = 10, Name = "IT"},
                new Department { ID = 20, Name = "HR"},
                new Department { ID = 30, Name = "Sales"},
            };
        }
    }
}
