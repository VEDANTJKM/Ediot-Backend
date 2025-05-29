using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Record
{
    public int? PersonId { get; set; }

    public string? Name { get; set; }

    public string? Age { get; set; }

    public string? City { get; set; }

    public string? CityName { get; set; }

    public int? Pincode { get; set; }

    public string? Country { get; set; }

    public int? Values { get; set; }
}
