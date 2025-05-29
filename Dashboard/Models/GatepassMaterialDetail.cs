using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class GatepassMaterialDetail
{
    public int Id { get; set; }

    public string? MaterialName { get; set; }

    public string? MaterialShape { get; set; }

    public string? MaterialGrade { get; set; }
}
