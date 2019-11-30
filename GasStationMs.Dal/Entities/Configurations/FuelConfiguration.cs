using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GasStationMs.Dal.Entities.Configurations
{
    class FuelConfiguration : IEntityTypeConfiguration<Fuel>
    {
        public void Configure(EntityTypeBuilder<Fuel> builder)
        {
            //----------Properties------------
            //Name
            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(20);

            //Price
            builder
                .Property(f => f.Price)
                .IsRequired();
        }
    }
}
