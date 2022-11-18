using BackendApi.Model;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Claim> claims { get; set; }
        public DbSet<Owner> owner { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }

    }
}
