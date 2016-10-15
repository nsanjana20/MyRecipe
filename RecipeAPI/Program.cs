using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipe = new Recipe();
            recipe.Name = "Onion Rings";
            recipe.Type = "Appetizer";
            recipe.Description = "A slightly sweet batter makes these crispy rings extra special and delicious!";
            recipe.PreparationSteps = "1) Heat the oil in a large, deep skillet over medium high heat \n 2) Prepare pancake mix according to package directions \n 3) One at a time, dip Spanish onion rings into the prepared pancake batter, then into the hot oil. Fry until crispy and browned, about 3 minutes.Drain on paper towels";
            recipe.PreparationTime = 0.10M;
            recipe.Ingredients = "1 quart oil, 1 cup dry pancake mix, 1 large Spanish onion (sliced into rings)";
            recipe.Servings = 4;

            RecipeStore.AddRecipe(recipe);

            RecipeStore.PrintRecipe();
        }
    }
}
