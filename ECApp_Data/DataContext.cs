using System;
using Microsoft.EntityFrameworkCore;

namespace ECApp_Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Seller" },
                new Role { Id = 2, Name = "Buyer" },
                new Role { Id = 3, Name = "Admin" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Mehmet Ali", Password = "adminpassword", RoleId = 3 }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Kıyafetler" },
                new Category { Id = 2, Name = "Tişörtler" },
                new Category { Id = 3, Name = "Pantolonlar" },
                new Category { Id = 4, Name = "Mayolar" },
                new Category { Id = 5, Name = "Pijamalr" },
                new Category { Id = 6, Name = "Spor Giyim" },
                new Category { Id = 7, Name = "Tulumlar" },
                new Category { Id = 8, Name = "Kabanlar" },
                new Category { Id = 9, Name = "Ceketler" },
                new Category { Id = 10, Name = "Ayakkabılar" }
            );
        }
    }
}

