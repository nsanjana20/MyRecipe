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
            recipe.Ingredients = "1 quart oil; 1 cup dry pancake mix; 1 large Spanish onion (sliced into rings)";
            recipe.Servings = 4;

            RecipeStore.AddRecipe(recipe);
            RecipeStore.PrintRecipe();

            recipe = new Recipe();
            recipe.Name = "No-Fry Onion Rings";
            recipe.Type = "Appetizer";
            recipe.Description = "Oven-baked onion rings with the flavor and crunch of traditional deep-fried onion rings";
            recipe.PreparationSteps = "Preheat oven to 450°F. Cover 2 baking sheets with aluminum foil; spray evenly with cooking spray.\n 2) Separate onion slices into rings.Dip into milk, then into the flour, turning to evenly coat both sides of each onion ring.Dip coated onion rings in egg whites, then into cornflake crumbs, again turning to evenly coat both sides of each onion ring.Place in single layer on prepared baking sheets \n 3) Bake 12 to 15 minutes or until onions are tender and golden brown.";
            recipe.PreparationTime = 0.25M;
            recipe.Ingredients = "PAM Olive Oil No-Stick Cooking Spray; 1 large sweet onion, cut into 1 / 2 - inch - thick slices; 1 / 3 cup fat free milk; 1 cup Ultragrain® All Purpose Flour; 4 large egg whites, lightly beaten; 2 cups cornflake crumbs";
            recipe.Servings = 6;

            RecipeStore.AddRecipe(recipe);
            RecipeStore.PrintRecipe();

            RecipeStore.SearchRecipe("Ring");
        }
    }
}
