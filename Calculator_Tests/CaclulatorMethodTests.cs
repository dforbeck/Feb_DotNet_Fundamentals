using Calculator_RepositoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class CaclulatorMethodTests
    {
        CalculatorRepository _calcRepo;
        int a;
        int b;
        int x;
        int y;

        [TestInitialize]
        public void Arrange()
        {
            _calcRepo = new CalculatorRepository();
            a = 1;
            b = 5;
            x = 2;
            y = 6;

        }

        [TestMethod]
        public void CalculatorRepository_AddTwoNumbers_ShouldReturnCorrectSum()
        {
            var expected = 6;
            var actual = _calcRepo.AddTwoNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_SubtractTwoNumbers_ShouldReturnCorrectValue()
        {
            var expected = 4;
            var actual = _calcRepo.SubtractTwoNumbers(b, a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_MultiplyTwoNumbers_ShouldReturnCorrectValue()
        {
            var expected = 10;
            var actual = _calcRepo.MultiplyTwoNumbers(b, x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_DivideTwoNumbers_ShouldReturnCorrectValue()
        {
            var expected = 3;
            var actual = _calcRepo.DivideTwoNumbers(y, x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_GetRemainder_ShouldReturnCorrectValue()
        {
            var expected = 1;
            var actual = _calcRepo.GetRemainder(b, x);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(15, 1, 2, 3, 4, 5)]
        [DataRow(18, 1, 2, 6, 4, 5)]
        [DataRow(22, 1, 9, 3, 4, 5)]
        [DataRow(34, 2, 23, 4, 5, 0)]
        public void CalculatorRepository_AddMultipleNumbers_ShouldReturnCorrectValue(int expectedInt, int a, int b, int c, int d, int e)
        {
            decimal[] numbers = { a, b, c, d, e };

            var actual = _calcRepo.AddMultipleNumbers(numbers);
            decimal expected = expectedInt;

            Assert.AreEqual(expected, actual);
        }
    }
}
