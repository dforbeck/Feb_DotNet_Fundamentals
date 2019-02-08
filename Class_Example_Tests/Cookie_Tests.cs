using System;
using System.Collections.Generic;
using Class_Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class_Example_Tests
{
    [TestClass]
    public class Cookie_Tests
    {
        [TestMethod]
        public void MakeingACookie()
        {
            Cookie cookie = new Cookie();
            cookie.BatchSize = 45;
            cookie.Ingredients = new List<string>(new string[]{ "sugar", "macadamia nuts", "flour", "eggs", "vanilla" });
            cookie.IsGlutenFree = false;
            cookie.Name = "White Macadamia Nut";

            Cookie cookieTwo = new Cookie();
            cookieTwo.BatchSize = 30;
            cookieTwo.Ingredients = new List<string>(new string[] { "sugar", "peanut butter", "almond flour", "eggs", "vanilla" });
            cookieTwo.IsGlutenFree = true;
            cookieTwo.Name = "Peanut Butter";
        }
    }
}
