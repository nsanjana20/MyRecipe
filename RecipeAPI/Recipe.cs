using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class Recipe
    {
        #region Properties
        [Key]
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }        
        public decimal PreparationTime { get; set; }        
        public int Servings { get; set; }
        public static List<RecipeIngredients> rIList { get; set; }
        public static List<RecipePreparation> rPList { get; set; }
        #endregion

        #region Constructors
        public Recipe()
        {
            rIList = new List<RecipeIngredients>();
            rPList = new List<RecipePreparation>();
        }
        #endregion

        #region Methods
        public static void AddRecipeIngredients(RecipeIngredients rI)
        {
            rIList.Add(rI);
        }
        public static void AddRecipePreparation(RecipePreparation rP)
        {
            rPList.Add(rP);
        }
        public static void PrintRI(int id)
        {
            foreach (var r in rIList)
            {
                if(r.RecipeId == id)
                Console.WriteLine("Recipe id: {0}, Name: {1}, quantity: {2}", r.RecipeId, r.name, r.quantity);
            }
        }
        public static void PrintRP(int id)
        {
            foreach (var r in rPList)
            {
                if(r.RecipeId == id)
                Console.WriteLine("Recipe id: {0}, step number : {1}, step description: {2}", r.RecipeId, r.StepId, r.StepDescription);
            }
        }
        #endregion
    }
}
