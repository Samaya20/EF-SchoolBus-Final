namespace SchoolBusData_Models.Base;

public abstract class BaseEntity
{
    public BaseEntity()
    {
        CreatedTime = DateTime.Now;
        IsDeleted = false;
    }
    public int Id { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime ModifiedTime { get; set; }
    public bool IsDeleted { get; set; }

}
