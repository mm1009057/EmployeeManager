using EmployeeManager;

class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(12345, "Joe", "Program1",10000, 92000);
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee(12346, "John", "Graphic1", 56000, 24, 600);
        Contractor contractor = new Contractor(12354, "Jane", "Program19", 79000, new DateTime(2026, 4, 12));

        Console.WriteLine(fullTimeEmployee.ToString());
        fullTimeEmployee.CalculatePay();

        Console.WriteLine(partTimeEmployee.ToString());
        partTimeEmployee.CalculatePay();

        Console.WriteLine(contractor.ToString());
        contractor.CalculatePay();
    }
}
