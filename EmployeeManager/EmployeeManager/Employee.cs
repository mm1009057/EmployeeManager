using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(int id, string name, string department, decimal BaseSalary)
        {
            ID = id;
            Name = name;
            Department = department;
            BaseSalary = basesalary;
        }
    }
}
