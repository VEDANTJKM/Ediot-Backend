using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MachineDetail
{
    public int Id { get; set; }

    public string? MachineType { get; set; }

    public string? MachineName { get; set; }

    public string? Dept { get; set; }

    public string? Resource { get; set; }

    public string? MachiningType { get; set; }

    public string? Resource1 { get; set; }
}
