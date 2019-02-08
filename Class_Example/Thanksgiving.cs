using System.Collections.Generic;

namespace Class_Example
{
    public enum FoodType { Dessert, Entre, Side, Sauce, Appetizer }
    public class Thanksgiving
    {
        public string Name { get; set; }
        public bool IsFavorite { get; set; }
        public FoodType FoodType { get; set; }
        public decimal Cost { get; set; }
        public List<string> Ingredients { get; set; }

        public Thanksgiving()
        {
            Ingredients = new List<string>();
        }

        public Thanksgiving(string name, bool isFav, FoodType type, decimal cost) : this()
        {
            Name = name;
            IsFavorite = isFav;
            FoodType = type;
            Cost = cost;
        }
    }
}
