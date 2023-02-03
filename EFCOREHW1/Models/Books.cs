namespace EFCOREHW1.Models;

public class Books : BaseEntity
{
    public string Name { get; set; }
    public int PageCount { get; set; }

    public ICollection<BookTypes>BookTypes { get; set; }
    public ICollection<Students>Student { get; set; }
}
