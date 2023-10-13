using Microsoft.EntityFrameworkCore;
using testapi.Models;

namespace testapi.Data
{
    public class WareHouseDbContext : DbContext
    {
        public WareHouseDbContext(DbContextOptions<WareHouseDbContext> options) : base(options) { }
        public DbSet<User> Users => Set<User>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Product> Products => Set<Product>();





    }
}
