using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionPlanningPriority
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public int? Priority { get; set; }

    public string? ChangeRemark { get; set; }

    public DateTime? ChangeDate { get; set; }

    public string? ChangeBy { get; set; }
}
