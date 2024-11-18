using Microsoft.EntityFrameworkCore;

namespace workshop.Entities
{
    public class mvcPortalContext:DbContext
    {
        public mvcPortalContext(DbContextOptions<mvcPortalContext> options)
                    : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Job> Jobslist { get; set; }

        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-5M9L3AJN\\MSSQLSERVER02;Initial Catalog=mvc_workshop;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
