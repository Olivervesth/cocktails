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
            Database.SetInitializer<CocktailContext>(new DropCreateDatabaseAlways<CocktailContext>());//Only have the database running when we have the project startet
        }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
