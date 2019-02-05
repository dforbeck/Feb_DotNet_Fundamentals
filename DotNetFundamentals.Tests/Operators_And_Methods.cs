using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals.Tests
{
    [TestClass]
    public class Operators_And_Methods
    {
        int a;
        int b;
        int x;

        [TestInitialize]
        public void Arrange()
        {
            a = 3;
            b = 9;
            x = 5;
        }

        [TestMethod]
        public void AddTwoNumbers_Test()
        {
            var expected = 12;
            var actual = AddTwoNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractTwoNumbers_Test()
        {
            var expected = 6;
            var actual = SubtractTwoNumbers(b, a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyTwoNumbers_Test()
        {
            var actual = MultiplyTwoNumbers(a, b);
            var expected = 27;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTwoNumbers_Test()
        {
            var actual = DivideTwoNumbers(b, a);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetRemainder_Test()
        {
            int c = b % x;
            var expected = 4;
            var actual = GetRemainder(b, x);

            Assert.AreEqual(expected, actual);
        }

        public int AddTwoNumbers(int x, int y) => x + y;
        public int SubtractTwoNumbers(int x, int y) => x - y;
        public int MultiplyTwoNumbers(int x, int y) => x * y;
        public int DivideTwoNumbers(int x, int y) => x / y;
        public int GetRemainder(int x, int y) => x % y;
    }
}
 