﻿namespace EFCOREHW1.Models;

public class Authors : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<Books> Books { get; set; }
}
