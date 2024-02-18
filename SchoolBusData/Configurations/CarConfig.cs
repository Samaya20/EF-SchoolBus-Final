using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBusData_Models.Derived;

namespace SchoolBusData.Configurations;

internal class CarConfig : IEntityTypeConfiguration<Class>
{
    public void Configure(EntityTypeBuilder<Class> builder)
    {
 //       builder.HasData(
 //    new Car { Id = 3, Name = "Car 1", Number = "123", SeatCount = 5 },
 //    new Car { Id = 4, Name = "Car 2", Number = "456", SeatCount = 4 }
 //);
    }
}
