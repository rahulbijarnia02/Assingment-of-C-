using System;
using System.Collections.Generic;

namespace myapp.Entities;

public partial class Employee
{
    public int UserId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public int? Contact { get; set; }

    public int? DeptId { get; set; }

    public virtual Dept Dept { get; set; }
}
