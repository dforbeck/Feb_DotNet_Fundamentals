using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals.Tests
{
    [TestClass]
    public class Value_Types
    {
        public void ValueTypes()
        {
            char character = '2';

            bool hasLegs = true;
            bool isOn = false;

            //Number Types
            byte byteMin = 0;
            byte byteMax = 255;

            short shortMin = -32768;
            short shortMax = 32767;

            int intMin = -24789798;
            int intMax = 24789798;

            long longerNum = 234892751234248981;

            //Decimal value options in increasing order by size.
            float floatNum = 12.44f;

            double doubleNum = 2.567534563d;

            decimal decNum = 2.5478357024501285192358609m;

            int? nullibleInt = null;

            //Example of DateTime Reference Type
            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);
        }
    }
}
