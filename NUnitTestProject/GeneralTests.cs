using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    [TestFixture]
    public class GeneralTests
    {
        // TestCase array
        [TestCase(new int[] { 2, 4, 6 })]
        public void Check_AllNumbersAreEven(int[] numbers)
        {
            bool result = !numbers.Any(n => n % 2 != 0);

            Assert.That(result == true);
        }


    }
}
