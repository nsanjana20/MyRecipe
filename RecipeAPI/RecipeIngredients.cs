using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class RecipeIngredients
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeID { get; set; }
        public virtual Recipe Recipe { get; set; }

        [ForeignKey("Ingredients")]
        public int IngredientId { get; set; }
        public virtual Ingredients Ingredients { get; set; }

        public string quantity { get; set; }
    }
}
