using SchoolBusData_Models.Base;

namespace SchoolBusData_Models.Derived;

public class Ride : BaseEntity
{

    // Foreign keys
    public int CarId { get; set; }
    public int? DriverId { get; set; }


    // Navigation prop
    public virtual Car? Car { get; set; }
    public virtual Driver? Driver { get; set; }
    public virtual List<Student>? Students { get; set; }
}
