using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class RecipePreparation
    {
        #region Properties
        public int RecipeId { get; set; }
        public int StepId { get; set; }
        public string StepDescription { get; set; }
        #endregion
    }
}