using System;
using Calculator_RepositoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class CaclulatorMethodTests
    {
        CalculatorRepository _calcRepo = new CalculatorRepository();

        [TestMethod]
        public void CalculatorRepository_AddTwoNumbers_ShouldReturnCorrectSum()
        {
            int a = 1;
            int b = 5;

            var expected = 6;
            var actual = _calcRepo.AddTwoNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_SubtractTwoNumbers_ShouldReturnCorrectValue()
        {
            int a = 1;
            int b = 5;

            var expected = 4;
            var actual = _calcRepo.SubtractTwoNumbers(b, a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_MultiplyTwoNumbers_ShouldReturnCorrectValue()
        {
            int a = 2;
            int b = 5;

            var expected = 10;
            var actual = _calcRepo.MultiplyTwoNumbers(b, a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_DivideTwoNumbers_ShouldReturnCorrectValue()
        {
            int a = 2;
            int b = 6;

            var expected = 3;
            var actual = _calcRepo.DivideTwoNumbers(b, a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_GetRemainder_ShouldReturnCorrectValue()
        {
            int a = 2;
            int b = 5;

            var expected = 1;
            var actual = _calcRepo.GetRemainder(b, a);

            Assert.AreEqual(expected, actual);
        }
    }
}
