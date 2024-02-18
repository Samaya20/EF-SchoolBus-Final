using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBusData_Models.Derived;

namespace SchoolBusData.Configurations;

public class DriverConfig : IEntityTypeConfiguration<Driver>
{
    public void Configure(EntityTypeBuilder<Driver> builder)
    {
        builder.Property(d => d.FirstName).IsRequired();
        builder.Property(d => d.LastName).IsRequired();
        builder.Property(d => d.Phone).IsRequired();
        builder.Property(d => d.Address).IsRequired();
        builder.Property(d => d.License).IsRequired();

        //builder.HasOne(d => d.Car)
        //    .WithOne(c => c.Driver)
        //    .HasForeignKey<Driver>(d => d.CarId)
        //    .OnDelete(DeleteBehavior.SetNull);

//        builder.HasData(
//    new Driver { Id = 1, FirstName = "John", LastName = "Doe", Phone = "123456789", Address = "123 Main St", License = "ABC123", CarId = 5 },
//    new Driver { Id = 2, FirstName = "Jane", LastName = "Smith", Phone = "987654321", Address = "456 Oak St", License = "XYZ456", CarId = 6 }
//);
    }
}
