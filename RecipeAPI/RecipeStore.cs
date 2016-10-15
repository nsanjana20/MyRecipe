using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAPI
{
    static class RecipeStore
    {
        #region Properties
        public static List<Recipe> Recipes { get; set; }
        #endregion

        #region Constructors
        static RecipeStore()
        {
            Recipes = new List<Recipe>();
        }
        #endregion

        #region Methods
        public static void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }
        public static void PrintRecipe()
        {
            foreach (var recipe in Recipes)
            {
                Console.WriteLine("Recipe name: {0}, Type: {1}, Description: {2}, Preparation time: {3}, Ingredients: {4}, Servings: {5}, Preparation Steps: {6}",
                    recipe.Name, recipe.Type, recipe.Description, recipe.PreparationTime, recipe.Ingredients, recipe.Servings, recipe.PreparationSteps);
       
            }
        }
        #endregion
    }
}
