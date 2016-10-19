﻿using System;
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
        public static List<string> SearchedResults { get; set; }
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
                Console.WriteLine("Recipe id: {0}, Name: {1}, Type: {2}, Description: {3}, Preparation time: {4}, Servings: {5}",
                    recipe.RecipeId, recipe.Name, recipe.Type, recipe.Description, recipe.PreparationTime, recipe.Servings);
                Recipe.PrintRI(recipe.RecipeId);
                Recipe.PrintRP(recipe.RecipeId);
            }            
        }
        
        public static void SearchRecipe(String name)
        {
            SearchedResults = new List<string>();
            foreach (var recipe in Recipes)
            {
                if (recipe.Name.Contains(name))
                    SearchedResults.Add(recipe.Name);                
            }
            foreach (var search in SearchedResults)
            {
                Console.WriteLine(search);
            }
        }
        #endregion
    }
}
