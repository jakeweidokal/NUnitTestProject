using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    [TestFixture]
    public class EmployeeTests
    {
        public virtual Employee CreateEmployee()
        {
            return new Employee();
        }

        [TestCase]
        public void Check_If_NameContainsIllegalCharacters()
        {
            Employee employee = CreateEmployee();
            employee.Name = "Te$t";

            var result = employee.ContainsIllegalCharacters();

            Assert.IsTrue(result);
        }
    }
}
