using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Year2022.Day1
{
    public class Elf
    {
        private List<int> FoodItems = new();

        public Elf()
        {
        }

        public void AddFoodItem(int foodItem)
        {
            FoodItems.Add(foodItem);
        }

        public int GetTotalCalories() => FoodItems.Sum();
    }
}