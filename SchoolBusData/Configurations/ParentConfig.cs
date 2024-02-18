using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBusData_Models.Derived;

namespace SchoolBusData.Configurations;

public class ParentConfig : IEntityTypeConfiguration<Parent>
{
    public void Configure(EntityTypeBuilder<Parent> builder)
    {
        builder.HasMany(p => p.Students)
               .WithOne(s => s.Parent)
               .HasForeignKey(s => s.ParentId);
        builder.Property(p => p.FirstName).IsRequired();
        builder.Property(p => p.LastName).IsRequired();
        builder.Property(p => p.PhoneNumber).IsRequired();

//        builder.HasData(
//    new Parent { Id = 1, FirstName = "Alice", LastName = "Doe", PhoneNumber = "111222333" },
//    new Parent { Id = 2, FirstName = "Bob", LastName = "Smith", PhoneNumber = "444555666" }
//);
    }
}
