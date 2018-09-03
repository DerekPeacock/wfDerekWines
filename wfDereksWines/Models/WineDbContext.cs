using System.Data.Entity;

namespace wfDereksWines.Models
{
    public class WineDbContext : DbContext
    {
        public WineDbContext(): base("DerekWines")
        {
        }

        public DbSet<Wine> Wines { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}