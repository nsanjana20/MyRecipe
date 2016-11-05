using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
