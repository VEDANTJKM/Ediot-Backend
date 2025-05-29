using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ResponsibilitiesMatrixPriority
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? Role { get; set; }

    public string? Responsibility { get; set; }

    public string? ResponsibilityType { get; set; }
}
