using System;
using System.Collections.Generic;

namespace myapp.Entities;

public partial class EmployeeList
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? Age { get; set; }

    public string Salary { get; set; }

    public string Designation { get; set; }
}
