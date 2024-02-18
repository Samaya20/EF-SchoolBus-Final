using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBusData_Models.Derived;

namespace SchoolBusData.Configurations;

public class RideConfig : IEntityTypeConfiguration<Ride>
{
    public void Configure(EntityTypeBuilder<Ride> builder)
    {
        //builder.Property(r => r.CarId).IsRequired();
        builder.Property(r => r.CarId);

        builder.HasOne(r => r.Car)
            .WithOne()
            .HasForeignKey<Ride>(r => r.CarId)
            .OnDelete(DeleteBehavior.NoAction);

        //builder.Property(r => r.DriverId).IsRequired();
        builder.Property(r => r.DriverId);


        builder.HasOne(r => r.Driver)
            .WithOne(d => d.Ride)
            .HasForeignKey<Ride>(r => r.DriverId)
            .OnDelete(DeleteBehavior.NoAction);

//        builder.HasData(
//    new Ride { Id = 1, CarId = 1 },
//    new Ride { Id = 2, CarId = 2 }
//);
    }
}
