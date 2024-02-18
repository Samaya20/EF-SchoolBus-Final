using SchoolBusData_Models.Base;

namespace SchoolBusData_Models.Derived;

public class Class : BaseEntity
{
    public string Name { get; set; } = null!;


    // Navigation prop
    public virtual List<Student>? Students { get; set; }
}
