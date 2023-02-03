using EFCOREHW1.Enums;

namespace EFCOREHW1.Models;

public class BaseEntity
{
    public int Id { get; set; }
    public DataStatus Status{ get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}
