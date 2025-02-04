using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManager
{
    public class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public decimal HoursWorked { get; set; }
        public PartTimeEmployee(int id, string name, string department, decimal basesalary, decimal hourlyrate, int hoursworked) : base(id, name, department, basesalary)
        {
            HourlyRate = hourlyrate;
            HoursWorked = hoursworked;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Hourly Rate: {HourlyRate}, Hours Worked: {HoursWorked}, Base Salary: {BaseSalary:C}";
        }

        public override void CalculatePay()
        {
            decimal total = BaseSalary + (HourlyRate * HoursWorked);
            Console.WriteLine("Pay is " + total);
        }
    }  
}
