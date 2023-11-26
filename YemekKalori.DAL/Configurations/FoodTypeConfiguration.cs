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
    public class FoodTypeConfiguration : IEntityTypeConfiguration<FoodType>
    {
        public void Configure(EntityTypeBuilder<FoodType> builder)
        {
            builder.ToTable("Food Types");

            builder.HasData
                (
                    new FoodType
                    {
                        Id = 1,
                        Name = "Meyve"
                    },

                    new FoodType
                    {
                        Id = 2,
                        Name = "Sebze"
                    },
                    new FoodType
                    {
                        Id = 3,
                        Name = "Et"
                    },

                    new FoodType
                    {
                        Id = 4,
                        Name = "Süt Ürünleri"
                    },
                    new FoodType
                    {
                        Id = 5,
                        Name = "Baklagiller"
                    }
                ) ;
            //throw new NotImplementedException();
        }
    }
}
