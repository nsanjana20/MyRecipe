using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class RecipeIngredients
    {
        #region Properties
        public int RecipeId { get; set; }
        public string name { get; set; }
        public string quantity { get; set; }
        #endregion
    }
}
