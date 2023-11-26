using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekKalori.DAL.Configurations
{
    public class FoodTypeConfiguration : IEntityTypeConfiguration<FoodTypeConfiguration>
    {
        public void Configure(EntityTypeBuilder<FoodTypeConfiguration> builder)
        {
            builder.ToTable("Food Types");

            
            //throw new NotImplementedException();
        }
    }
}
