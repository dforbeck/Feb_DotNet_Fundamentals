using Class_Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Class_Example_Tests
{
    [TestClass]
    public class Thanksgiving_Tests
    {
        [TestMethod]
        public void MakeThanksgivingItem()
        {
            Thanksgiving turkey = new Thanksgiving();
            turkey.Name = "Turkey";
            turkey.Ingredients = new List<string>(new string[] { "turkey", "apples", "cinnamon", "oil", "sage", "rosemary" });
            turkey.FoodType = FoodType.Entre;
            turkey.Cost = 35m;
            turkey.IsFavorite = true;

            Thanksgiving mashedPotatos = new Thanksgiving();
            mashedPotatos.Name = "Mashed Potatos";
            mashedPotatos.Ingredients = new List<string>(new string[] { "potatos", "butter", "salt", "pepper" });
            mashedPotatos.FoodType = FoodType.Side;
            mashedPotatos.Cost = 5m;
            mashedPotatos.IsFavorite = true;

            Thanksgiving cranberrySauce = new Thanksgiving();
            cranberrySauce.Name = "Cranberry Sauce";
            cranberrySauce.Ingredients = new List<string>(new string[] { "cranberries", "sugar" });
            cranberrySauce.FoodType = FoodType.Sauce;
            cranberrySauce.Cost = 3m;
            cranberrySauce.IsFavorite = true;

            Thanksgiving salad = new Thanksgiving();
            salad.Name = "Salad";
            salad.Ingredients = new List<string>(new string[] { "lettuce", "apples", "spinach", "cheese", "vinagrette", "cucumbers" });
            salad.FoodType = FoodType.Side;
            salad.Cost = 7m;
            salad.IsFavorite = false;
        }

        [TestMethod]
        public void MakeThanksgivingItemWithConstructors()
        {
            Thanksgiving turkey = new Thanksgiving("Turkey", true, FoodType.Entre, 35)
            {
                Ingredients = { "turkey", "apples", "cinnamon", "oil", "sage", "rosemary" }
            };

            Thanksgiving mashedPotatos = new Thanksgiving("Mashed Potatos", true, FoodType.Side, 5m)
            {
                Ingredients = { "potatos", "butter", "salt", "pepper" }
            };

            Thanksgiving cranberrySauce = new Thanksgiving("Cranberry Sauce", true, FoodType.Sauce, 3m)
            {
                Ingredients = { "cranberries", "sugar" }
            };

            Thanksgiving salad = new Thanksgiving("Salad", false, FoodType.Side, 7m)
            {
                Ingredients = { "lettuce", "apples", "spinach", "cheese", "vinagrette", "cucumbers" }
            };
        }
    }
}
