using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Models
{
    public class EmpDBContext : DbContext
    {
        public EmpDBContext(DbContextOptions<Empdbcontext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().ToTable("Employee");
        }


        public DbSet<Employee> Employee { get; set; }
    }
}
