using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManager
{
    public class FullTimeEmployee : Employee
    {
        public decimal AnnualBonus { get; set; }
        public FullTimeEmployee(int id, string name, string department, decimal basesalary, decimal annualbonus) : base(id, name, department, basesalary)
        {
            AnnualBonus = annualbonus;
        }

        public override string ToString()
        {

            return $"ID: {ID}, Name: {Name}, Department: {Department}, Annual Bonus: {AnnualBonus}, Base Salary: {BaseSalary:C}";

        }
        public override void CalculatePay()
        {
            decimal total = AnnualBonus + BaseSalary;
            Console.WriteLine("Pay is " + total);
        }
    }  
}
