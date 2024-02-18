using SchoolBusData_Models.Base;

namespace SchoolBusData_Models.Derived;

public class Parent : BaseEntity
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;


    // Navigation prop
    public virtual List<Student>? Students { get; set; }
}
