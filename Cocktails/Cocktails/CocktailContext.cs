using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class CocktailContext : DbContext
    {
        public CocktailContext() : base()
        {
            //Database.SetInitializer<CocktailContext>(new CreateDatabaseIfNotExists<CocktailContext>());
            Database.SetInitializer<CocktailContext>(new DropCreateDatabaseAlways<CocktailContext>());
        }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
