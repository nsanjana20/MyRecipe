using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAPI
{
    class Recipe
    {
        #region Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string PreparationSteps { get; set; }
        public decimal PreparationTime { get; set; }
        public string Ingredients { get; set; }
        public int Servings { get; set; }
        #endregion        

    }
}
