using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Machine
{
    public int Mid { get; set; }

    public int Id { get; set; }

    public string? Machinename { get; set; }

    public string? Type { get; set; }

    public bool? Active { get; set; }
}
