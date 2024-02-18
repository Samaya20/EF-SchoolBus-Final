using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBusData_Models.Derived;

namespace SchoolBusData.Configurations;

public class StudentConfig : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(s => s.FirstName).IsRequired();
        builder.Property(s => s.LastName).IsRequired();
        builder.Property(s => s.Address).IsRequired();
        builder.Property(s => s.OtherAddress);

        builder.HasOne(s => s.Parent)
            .WithMany(p => p.Students)
            .HasForeignKey(s => s.ParentId);

        builder.HasOne(s => s.Ride)
            .WithMany(r => r.Students)
            .HasForeignKey(s => s.RideId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(s => s.Class)
            .WithMany(c => c.Students)
            .HasForeignKey(s => s.ClassId)
            .OnDelete(DeleteBehavior.NoAction);

//        builder.HasData(
//    new Student { Id = 1, FirstName = "Alice", LastName = "Doe", Address = "123 Main St", ParentId = 1, RideId = 1, ClassId = 1 },
//    new Student { Id = 2, FirstName = "Bob", LastName = "Smith", Address = "456 Oak St", ParentId = 2, RideId = 2, ClassId = 2 }
//);
    }
}
