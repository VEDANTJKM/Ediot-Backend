using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Trial
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Education { get; set; }

    public decimal? Percentage { get; set; }
}
