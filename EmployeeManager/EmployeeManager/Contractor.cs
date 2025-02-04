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
    public class Contractor : Employee
    {
        public DateTime ContractExpiryDate { get; set; }
        public Contractor(int id, string name, string department, decimal basesalary, DateTime contractexpirydate) : base(id, name, department, basesalary)
        {
            ContractExpiryDate = contractexpirydate;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Contract Expiry Date: {ContractExpiryDate}, Base Salary: {BaseSalary:C}";
        }
        public override void CalculatePay()
        {
            decimal total = BaseSalary;
            Console.WriteLine("Pay is " + total);
        }
    }  
}
