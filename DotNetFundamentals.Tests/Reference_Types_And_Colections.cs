using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DotNetFundamentals.Tests
{
    [TestClass]
    public class Reference_Types_And_Colections
    {
        public void ReferenceTypes()
        {
            //Classes
            //Interfaces

            string hello = "Hello World";
        }

        public void Collections()
        {
            string[] arrayOfStrings = { "This", "can be", "any collection", "of strings" };
            int[] arrayOfNumbers = { 1, 5, 43, 6 };

            List<string> strings = new List<string>();
            Queue<string> stringQueue = new Queue<string>();
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            SortedList<int, string> sortedKeyValuePairs = new SortedList<int, string>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        //Challenge: Write a method that will take a parameter of a string and then add that string to a sentence.
        public string SayHello(string hello)
        {
            string greeting = "Hello " + hello;
            Console.WriteLine(greeting);
            return greeting;
        }

        [TestMethod]
        public void SayHello_Test()
        {
            //Arrange
            string name = "John";

            //Act
            var expected = "Hello John";
            var actual = SayHello(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
