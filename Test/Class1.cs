using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculator;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test_Method1()
        {
            // Arrange
            var testInstance = new AddClass();

            // Act
            var testResult = testInstance.AddTwo(9, 5);

            // Assert
            Assert.AreEqual(14, testResult, "I expect 14");
            
        }
    }
}
