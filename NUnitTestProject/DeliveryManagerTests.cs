using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    public class DeliveryManagerTests : EmployeeTests
    {
        public override Employee CreateEmployee()
        {
            return new DeliveryManager();
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
