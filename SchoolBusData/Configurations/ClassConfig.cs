using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBusData_Models.Derived;

namespace SchoolBusData.Configurations;

public class ClassConfig : IEntityTypeConfiguration<Class>
{
    public void Configure(EntityTypeBuilder<Class> builder)
    {
        builder.Property(c => c.Name).IsRequired();

        //builder.HasData(
        //     new Class { Id = 5, Name = "Class A" },
        //     new Class { Id = 6, Name = "Class B" }
        //);
    }
}
