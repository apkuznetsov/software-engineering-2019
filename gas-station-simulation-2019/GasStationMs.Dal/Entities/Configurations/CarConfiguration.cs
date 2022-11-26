using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GasStationMs.Dal.Entities.Configurations
{
    class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            //----------Properties------------
            //Name
            builder
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(40);

            //Name
            builder
                .Property(c => c.TankVolume)
                .IsRequired();

            //FuelTypeId
            builder
                .Property(c => c.FuelTypeId)
                .IsRequired(false);

            //IsTruck
            builder
                .Property(c => c.IsTruck)
                .IsRequired()
                .HasDefaultValue(false);

            //----------Relations------------
            //Fuel
            builder.HasOne<Fuel>(c => c.FuelType)
                .WithMany(f => f.Cars)
                .HasForeignKey(c => c.FuelTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
