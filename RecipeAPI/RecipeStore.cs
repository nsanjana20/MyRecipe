using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RecipeAPI
{
    public static class RecipeStore
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

        public static List<Recipe> GetRecipes()
        {
            using (var model = new RecipeModel())
            {
                var db_Recipes = model.Db_Recipes.Include(r => r.Account);
                return db_Recipes.ToList();
            }
                        
        }
        public static void PrintIngredients(int id)
        {
            using (var model = new RecipeModel())
            {
                foreach (var r in model.Db_Ingredients)
                {                   
                    Console.WriteLine("Recipe id: {0}, Name: {1}", r.Id, r.name);
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
