using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeTest;

namespace EmployeeTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void CalculatePay_ShouldReturnBaseSalaryPlusAnnualBonus()
        { 
            // Arrange
            var fullTimeEmployee = new FullTimeEmployee();
            var expectedPay = 100000;

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                FullTimeEmployee.CalculatePay();

                // Assert
                var result = sw.ToString().Trim();
                Assert.AreEqual(expectedPay, result);
            }
        }
    }
}