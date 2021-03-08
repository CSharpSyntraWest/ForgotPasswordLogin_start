using IdentityByExamples.Models.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace IdentityByExamples.Models
{
    public class ApplicationContext : IdentityDbContext//ADDED 1 DbContext
    {
        public ApplicationContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);//ADDED 2
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());// ADDED 6
            SeedAdminUserRole(modelBuilder);
            /*//ADDED 7
             * PM> Add-Migration InsertedRoles
             * PM> Update-Database*/
            //ADDED 8 -> check table AspNetRoles in db Roles VISTOR en ADMIN
            /*ADDED 9 User Registration with ASP.NET Core Identity
            *https://code-maze.com/user-registration-aspnet-core-identity/
            */
        }
        private void SeedAdminUserRole(ModelBuilder modelBuilder)
        {//https://medium.com/@frankofoedu/how-to-seed-identity-role-with-associated-user-in-asp-net-core-ef-core-e40ecd643d0f
            #region seed custom admin role
            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = Guid.NewGuid().ToString();
            //seed custom admin role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "administrator",
                NormalizedName = "ADMINISTRATOR"
            });
            //seed admins
            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                
                Id = ADMIN_ID,
                UserName = "admin@x.com",
                NormalizedUserName = "admin@x.com".ToUpper(),
                Email = "admin@x.com",
                NormalizedEmail = "admin@x.com".ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admin"),
                SecurityStamp = string.Empty
            });
            //seed admin into role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
            #endregion
        }
        public DbSet<Employee> Employees { get; set; }
}
}
