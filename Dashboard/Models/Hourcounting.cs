using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Hourcounting
{
    public string Gpno { get; set; } = null!;

    public string? Suppliername { get; set; }

    public string? Hourcount { get; set; }
}
