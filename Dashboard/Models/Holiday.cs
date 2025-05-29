using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Holiday
{
    public int Id { get; set; }

    public string? Day { get; set; }

    public DateOnly? Date { get; set; }

    public string? Name { get; set; }

    public string? Active { get; set; }
}
