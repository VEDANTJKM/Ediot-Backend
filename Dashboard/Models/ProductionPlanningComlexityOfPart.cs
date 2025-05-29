using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionPlanningComlexityOfPart
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? SystemName { get; set; }

    public string? PartNum { get; set; }

    public int? Complexity { get; set; }

    public string? ChangeRemark { get; set; }

    public DateTime? ChangeDate { get; set; }

    public string? ChangeBy { get; set; }
}
