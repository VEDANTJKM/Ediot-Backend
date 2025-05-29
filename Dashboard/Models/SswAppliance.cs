using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class SswAppliance
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string? Refname { get; set; }

    public string? Subrefname { get; set; }

    public string? Refname1 { get; set; }
}
