using Microsoft.EntityFrameworkCore;

namespace MediatorDesignPattern.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JNJNVEQ\\MERTSQL; initial catalog=DbMediatorPattern; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
