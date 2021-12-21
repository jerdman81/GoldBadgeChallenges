using System.Collections.Generic;

namespace _01_KomodoCafe.Repository
{
    public class MenuItem
    {
        //POCOS -   Menu Class with Properties, constructors, and fields
        public MenuItem() { }

        public MenuItem(int mealId, string mealName, string mealDescription, decimal mealPrice, List<string> mealIngredient)
        {
            MealID = mealId;
            MealName = mealName;
            MealDescription = mealDescription;
            MealPrice = mealPrice;
            MealIngredient = mealIngredient;

        }

        //Unique Identifier
        // Meal ID
        public int MealID { get; set; }

        // Meal Name
        public string MealName { get; set; }


        // Meal Description

        public string MealDescription { get; set; }

        // List of Ingredients
        public List<string> MealIngredient { get; set; } = new List<string>();

        // Price
        public decimal MealPrice { get; set; }

    }

}
