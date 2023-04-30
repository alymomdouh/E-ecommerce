using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Infrastrucure.Data
{
    public class StoreContext : DbContext  
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        } 
        public DbSet<Product> Products { get; set; }
    }
}
