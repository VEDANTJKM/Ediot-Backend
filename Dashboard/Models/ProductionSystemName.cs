using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionSystemName
{
    public int Id { get; set; }

    public int? Mid { get; set; }

    public string? SystemNum { get; set; }

    public string? PartNum { get; set; }

    public int? Complexity { get; set; }

    public int? Priority { get; set; }

    public string? PartType { get; set; }

    public int? YearlyQty { get; set; }

    public int? FlStock { get; set; }

    public int? SnStock { get; set; }

    public int? Rev { get; set; }

    public decimal? CycleTime { get; set; }
}
