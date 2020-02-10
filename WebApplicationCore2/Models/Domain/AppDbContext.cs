using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationCore2.Models.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PartiesResponse> Parties { get; set; }
        public DbSet<Role> Roles { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "admin@mail.ru";
            string adminPassword = "123456";

            // добавляем роли
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            User adminUser = new User { Id = 1, Name = adminEmail, Password = adminPassword, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserParties>()
                .HasKey(t => new { t.UserId, t.PartieId });

            modelBuilder.Entity<UserParties>()
                .HasOne(sc => sc.User)
                .WithMany(s => s.UserParties)
                .HasForeignKey(sc => sc.UserId);

            modelBuilder.Entity<UserParties>()
                .HasOne(sc => sc.PartiesResponse)
                .WithMany(c => c.UserParties)
                .HasForeignKey(sc => sc.PartieId);
        }


    }
}
