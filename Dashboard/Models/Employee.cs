using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Employee
{
    public int PersonId { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Country { get; set; }

    public string? Cityname { get; set; }

    public int? Postalcode { get; set; }

    public string? Password { get; set; }

    public int? Number { get; set; }
}
