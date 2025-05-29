using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Maintenance
{
    public int Mid { get; set; }

    public int Id { get; set; }

    public string? Maintenancename { get; set; }

    public string? Active { get; set; }
}
