using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public class Employee
    {
        private int id;
        private string name;
        private string department;
        private decimal basesalary;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(int id, string name, string department, decimal basesalary)
        {
            ID = id;
            Name = name;
            Department = department;
            BaseSalary = basesalary;
        }

        public virtual void CalculatePay()
        {

        }

        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"");
        }
    }
}
