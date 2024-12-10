using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class Appdbcontext : DbContext
    {

        public Appdbcontext(DbContextOptions<Appdbcontext> options)
                 : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=DemoData;Integrated Security=True");
            }
        }
        public DbSet<Employee> Employees { get; set; }
    }

}
