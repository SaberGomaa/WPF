using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public static class EmployeeList
    {
        public static List<Employee> Emps { get; set; }
        static EmployeeList()
        {
            Emps.Add(new Employee() { Id = 1 , Name = "Maher", Age=27 , Jop="Enginner"});
            Emps.Add(new Employee() { Id = 2 , Name = "Saber" , Age=23 , Jop="Enginner"});
            Emps.Add(new Employee() { Id = 3 , Name = "Eman" , Age=29 , Jop="Teacher"});
            Emps.Add(new Employee() { Id = 4 , Name = "Fatema" , Age=25 , Jop= "Teacher" });
            Emps.Add(new Employee() { Id = 5 , Name = "Enas" , Age=20 , Jop="Nurse"});
        }
    }
}
