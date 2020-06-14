using Microsoft.VisualStudio.TestTools.UnitTesting;
using payroll;

namespace payrollTest
{
    //my top 3 cyclomatic complexity units are Employee, HourlyEmployee, and Main itself
    //tests on HourlyEmployee also affect Employee
    //tests on Main were all based on menu driven items, making it difficult to unit test, so i tested my input checkers here
    [TestClass]
    public class payrollTest
    {
        [TestMethod]
        public void NewHourlyEmployeeIsNotNull()
        {
            HourlyEmployee e = new HourlyEmployee("Jane", "Doe", 42, 54687, 12.50M, 25M);
            Assert.IsNotNull(e);
        }
        [TestMethod]
        public void EmployeeCalculatedPayMath()
        {
            HourlyEmployee e = new HourlyEmployee("Jane", "Doe", 42, 54687, 12.50M, 25M);
            Assert.AreEqual(e.CalculatedPay, (12.50M * 25M));
        }
        [TestMethod]
        public void EmployeeNameOutput()
        {
            HourlyEmployee e = new HourlyEmployee("Jane", "Doe", 42, 54687, 12.50M, 25M);
            Assert.AreEqual(e.NameOutput(), "Name: Doe, Jane");
        }
        [TestMethod]
        public void EmployeeAgeOutput()
        {
            HourlyEmployee e = new HourlyEmployee("Jane", "Doe", 42, 54687, 12.50M, 25M);
            Assert.AreEqual(e.AgeOutput(), "Age: 42");
        }
        [TestMethod]
        public void EmployeeIDOutput()
        {
            HourlyEmployee e = new HourlyEmployee("Jane", "Doe", 42, 54687, 12.50M, 25M);
            Assert.AreEqual(e.IDOutput(), "Employee ID: 54687");
        }
        [TestMethod]
        public void IsIntInput()
        {
            string i = "5";
            Assert.AreEqual(UserInput.IntInput(i), 5);
        }
        public void IsntIntInput()
        {
            string i = "notint";
            Assert.AreEqual(UserInput.IntInput(i), 0);
        }
        [TestMethod]
        public void IsDecInput()
        {
            string i = "5.55";
            Assert.AreEqual(UserInput.DecInput(i), 5.55M);
        }
        public void IsntDecInput()
        {
            string i = "notdec";
            Assert.AreEqual(UserInput.DecInput(i), 0);
        }
        public void IsStringInput()
        {
            string i = "name";
            Assert.AreEqual(UserInput.StringInput(i), "name");
        }
        public void IsntStringInput()
        {
            string i = "50.50";
            Assert.IsNull(UserInput.StringInput(i));
        }
    }
}
