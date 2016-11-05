using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        public virtual ICollection<PreparationStep> PreparationSteps { get; set; }   
        public virtual ICollection<RecipeIngredients> RecipeIngredients { get; set; }   
        #endregion

       #region Methods
        
        public static void AddPreparationStep(PreparationStep step)
        {
            using (var model = new RecipeModel())
            {
                model.Db_PreparationSteps.Add(step);
                model.SaveChanges();
            }
        }
        
        public static void PrintSteps(int id)
        {
            using (var model = new RecipeModel())
            {
                foreach (var r in model.Db_PreparationSteps)
                {
                    if(r.RecipeId == id)
                    Console.WriteLine("Recipe id: {0}, step number : {1}, step description: {2}", r.RecipeId, r.StepId, r.StepDescription);
                }
            }
            
        }
        #endregion
    }
}
