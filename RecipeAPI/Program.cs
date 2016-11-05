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
            //var recipe = new Recipe();
            //var rI = new Ingredients();
            //var rP = new PreparationStep();

            //recipe.RecipeId = 1;
            //recipe.Name = "Onion Rings";
            //recipe.Type = "Appetizer";
            //recipe.Description = "A slightly sweet batter makes these crispy rings extra special and delicious!";
            //recipe.PreparationTime = 0.10M;
            //recipe.Servings = 4;

            //RecipeStore.AddRecipe(recipe);


            //rI.name = "oil";
            //rI.quantity = "1 quart";
            //RecipeStore.AddIngredient(rI);

            //rI.name = "Dry Pancake mix";
            //rI.quantity = "1 cup";
            //RecipeStore.AddIngredient(rI);

            //rI.name = "spanish onion";
            //rI.quantity = "1 large";
            //RecipeStore.AddIngredient(rI);

            //rP.RecipeId = recipe.RecipeId;
            //rP.StepId = 1;
            //rP.StepDescription = "Heat the oil in a large, deep skillet over medium high heat";
            //Recipe.AddPreparationStep(rP);
            //rP.StepId = 2;
            //rP.StepDescription = "Prepare pancake mix according to package directions ";
            //Recipe.AddPreparationStep(rP);
            //rP.StepId = 3;
            //rP.StepDescription = "One at a time, dip Spanish onion rings into the prepared pancake batter, then into the hot oil. Fry until crispy and browned, about 3 minutes.Drain on paper towels";
            //Recipe.AddPreparationStep(rP);

            //RecipeStore.PrintRecipe();

            Console.WriteLine("Welcome to Recipe store");
            Console.WriteLine("1. Add recipe");
            Console.WriteLine("2. Print recipe");
            Console.WriteLine("3. Search recipe");
            Console.Write("Please choose an option: ");
            var input = Console.ReadLine();
            int choice;
            if(!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid Choice");
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter recipe name");
                    var name = Console.ReadLine();
                    Console.WriteLine("Preparation time:");
                    decimal preptime;
                    if (!decimal.TryParse(Console.ReadLine(), out preptime))
                        return;
                    var recipe = new Recipe();
                    recipe.Name = name;
                    recipe.Type = "Appetizer";
                    recipe.Description = "A slightly sweet batter makes these crispy rings extra special and delicious!";
                    recipe.PreparationTime = preptime;
                    recipe.Servings = 4;
                    RecipeStore.AddRecipe(recipe);
                    break;
                case 2: break;
                case 3: break;
                default:
                    break;
            }

        }
    }
}
