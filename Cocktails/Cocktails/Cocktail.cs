using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Cocktail
    {
        [Key]
        public string Name { get; set; }
        //public ICollection<Ingredient> Ingredients { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
