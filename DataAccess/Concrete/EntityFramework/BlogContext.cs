using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    IConfigurationRoot configuration = new ConfigurationBuilder()
            //              .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //              .AddJsonFile("appsettings.json")
            //              .Build();
            //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            //}
            optionsBuilder.UseSqlServer(@"Data Source=94.73.170.34;Initial Catalog=u0919570_BlogPro; User Id=u0919570_user5E8;Password=B***********************;");
        }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }


    }
}
