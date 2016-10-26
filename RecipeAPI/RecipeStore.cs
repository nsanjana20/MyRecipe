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
        public static List<string> SearchedResults { get; set; }
        #endregion

        #region Constructors
        static RecipeStore()
        {
            
        }
        #endregion

        #region Methods
        public static void AddRecipe(Recipe recipe)
        {
            using (var model = new RecipeModel())
            {
                model.Db_Recipes.Add(recipe);
                model.SaveChanges();
            }                             
        }
        public static void AddIngredient(Ingredients rI)
        {
            using (var model = new RecipeModel())
            {
                model.Db_Ingredients.Add(rI);
                model.SaveChanges();
            }
        }

        public static void PrintRecipe()
        {
            using (var model = new RecipeModel())
            {
                foreach (var recipe in model.Db_Recipes)
                {
                    Console.WriteLine("Recipe id: {0}, Name: {1}, Type: {2}, Description: {3}, Preparation time: {4}, Servings: {5}",
                        recipe.RecipeId, recipe.Name, recipe.Type, recipe.Description, recipe.PreparationTime, recipe.Servings);

                    Recipe.PrintSteps(recipe.RecipeId);
                }
            }
                        
        }
        public static void PrintIngredients(int id)
        {
            using (var model = new RecipeModel())
            {
                foreach (var r in model.Db_Ingredients)
                {                   
                    Console.WriteLine("Recipe id: {0}, Name: {1}, quantity: {2}", r.Id, r.name, r.quantity);
                }
            }            
        }

        public static void SearchRecipe(String name)
        {
            SearchedResults = new List<string>();
            using (var model = new RecipeModel())
            {
                foreach (var recipe in model.Db_Recipes)
                {
                    if (recipe.Name.Contains(name))
                        SearchedResults.Add(recipe.Name);
                }
            }            
            foreach (var search in SearchedResults)
            {
                Console.WriteLine(search);
            }
        }
        #endregion
    }
}
