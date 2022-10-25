using _2DataAccessLayer.Context.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context
{   

    public class DBEntitiesContext : DbContext
    {
        public DBEntitiesContext(DbContextOptions<DBEntitiesContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Employee> Employees { get; set; }

<<<<<<< HEAD
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }
=======
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<ProductLoss> ProductLoss { get; set; }
>>>>>>> f1def32854d0f4774c418cb1f2eb0f17d2181dd8
        //public DbSet<Category> Categories { get; set; }
    }

}
