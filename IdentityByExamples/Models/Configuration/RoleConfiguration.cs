using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//ADDED 5 Class RoleConfiguration
/*Adding Roles to the Database
Having initial roles in the database is a quite common process, so let’s do that.

In the Configuration folder, we are going to create an additional class:
*/
namespace IdentityByExamples.Models.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { 
                    Name="Visitor",
                    NormalizedName = "VISITOR"
                },
                new IdentityRole{ 
                    Name = "Admin",
                    NormalizedName="ADMIN"
                });
            
        }
    }
}
