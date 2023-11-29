using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.Domain.Entities;

namespace YemekKalori.DAL.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.Property(a => a.FirstName).HasMaxLength(50);
            builder.Property(a => a.LastName).HasMaxLength(50);
            builder.HasIndex(a => a.Username).IsUnique();

            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property<string>("Password").HasField("_hashedPassword");

            builder.Property(u => u.BMI).HasComputedColumnSql("CAST([Weight] / POWER([Height], 2) AS DECIMAL(18,2))", stored: true);

            builder.HasData
                (
                    new User
                    {
                        Id = 1,
                        CreatedDate = DateTime.Now,
                        FirstName = "Admin",
                        LastName = "Admin",
                        Username = "admin",
                        Password = "Admin123",
                        Status = Domain.Enums.Status.Added,
                        Type = Domain.Enums.UserType.Admin
                    }
                );

            
            
        }
    }
}
