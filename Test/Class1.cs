using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculator;
using NUnit.Framework;
using StringCalculator;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test_Method1()
        {
            var testInstance = new AddClass();
            var testResult = testInstance.AddTwo(9,5);
        }
    }
}
