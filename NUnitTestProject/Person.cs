using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    public abstract class Person
    {
        public string? Name { get; set; }

        public bool ContainsIllegalCharacters()
        {
            return Name.Contains("$");
        }
    }
}
