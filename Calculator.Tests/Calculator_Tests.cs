using Calculator_RepositoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class Calculator_Tests
    {
        CalculatorRepository _calcRepoTest;
        decimal a;
        decimal b;
        decimal c;

        [TestInitialize]
        public void Arrange()
        {
            _calcRepoTest = new CalculatorRepository();
            a = 10m;
            b = 2m;
            c = 9m;
        }

        [DataTestMethod]
        [DataRow(5, 8, 13)]
        [DataRow(6, 8, 14)]
        [DataRow(2, 2, 4)]
        [DataRow(4, 6, 10)]
        [DataRow(6055, 12345, 18400)]
        public void CalculatorRepository_AddTwoNumbersByInt_ShouldReturnCorrectSum(int a, int b, int x)
        {
            //Act
            var actual = _calcRepoTest.AddTwoNumbersByInt(a, b);
            var expected = x;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_AddTwoNumbers_ShouldReturnCorrectSum()
        {
            //Act
            var actual = _calcRepoTest.AddTwoNumbers(a, b);
            var expected = 12m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_SubractTwoNumbers_ShouldReturnCorrectDifference()
        {
            //Act
            var actual = _calcRepoTest.SubtractTwoNumbers(a, b);
            var expected = 8m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_MultiplyTwoNumbers_ShouldReturnCorrectProduct()
        {
            var actual = _calcRepoTest.MultiplyTwoNumbers(a, b);
            var expected = 20m;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_DivideTwoNumbers_ShouldReturnCorrectValue()
        {
            var actual = _calcRepoTest.DivideTwoNumbers(a, b);
            var expected = 5m;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_GetRemainder_ShouldReturnCorrectValue()
        {
            var actual = _calcRepoTest.GetRemainder(c, b);
            var expected = 1m;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_AddMultipleNumbers_ShouldReturnCorrectSum()
        {
            decimal[] numbers = { 3m, 5m, 17m, 22m };
            decimal[] moreNumbers = { 1m, 2m, 3m };

            var actual = _calcRepoTest.AddMultipleNumbers(numbers);
            var expected = 47m;

            var actualTwo = _calcRepoTest.AddMultipleNumbers(moreNumbers);
            var expectedTwo = 6m;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedTwo, actualTwo);
        }
    }
}
