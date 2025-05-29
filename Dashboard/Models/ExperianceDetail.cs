using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ExperianceDetail
{
    public int ExperianceId { get; set; }

    public int Id { get; set; }

    public string Nameofcompany { get; set; } = null!;

    public string Addressofcompany { get; set; } = null!;

    public DateOnly Date1 { get; set; }

    public DateOnly Date2 { get; set; }

    public string Designation { get; set; } = null!;

    public string Monthlysalary { get; set; } = null!;
}
