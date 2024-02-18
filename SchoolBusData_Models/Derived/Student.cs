using SchoolBusData_Models.Base;

namespace SchoolBusData_Models.Derived;

public class Student : BaseEntity
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;


    public string Address { get; set; } = null!;

    public string? OtherAddress { get; set; }


    // Foreign keys
    public int ParentId { get; set; }

    public int? RideId { get; set; }

    public int ClassId { get; set; }


    // Navigation prop
    public virtual Parent? Parent { get; set; }

    public virtual Ride? Ride { get; set; }

    public virtual Class? Class { get; set; }
}
