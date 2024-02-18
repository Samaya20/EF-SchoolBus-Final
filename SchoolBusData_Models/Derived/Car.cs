using SchoolBusData_Models.Base;

namespace SchoolBusData_Models.Derived;

public class Car : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Number { get; set; } = null!;

    public int SeatCount { get; set; }


    // Navigation prop
    public virtual Driver? Driver { get; set; }
}
