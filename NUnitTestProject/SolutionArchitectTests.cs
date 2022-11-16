using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    public class SolutionArchitectTests : EmployeeTests
    {
        public override Employee CreateEmployee()
        {
            return new SolutionArchitect();
        }

        [TestCase]
        public new void Check_If_NameContainsIllegalCharacters()
        {
            Employee employee = CreateEmployee();
            employee.Name = "Te$t";

            var result = employee.ContainsIllegalCharacters();

            Assert.IsTrue(result);
        }
    }
}
