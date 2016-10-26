using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class PreparationStep
    {
        #region Properties
        [Key]
        public int StepId { get; set; }
        public string StepDescription { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeId { get; set; } 
        public virtual Recipe Recipe { get; set; }
        #endregion
    }
}