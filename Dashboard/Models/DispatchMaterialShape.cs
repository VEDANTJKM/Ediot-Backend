using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchMaterialShape
{
    public int Id { get; set; }

    public string? MaterialShape { get; set; }

    public string? MaterialGrade { get; set; }

    public string? MaterialType { get; set; }

    public bool? ActiveLogs { get; set; }
}
