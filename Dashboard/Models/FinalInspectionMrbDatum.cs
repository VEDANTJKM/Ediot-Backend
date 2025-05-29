using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionMrbDatum
{
    public int Id { get; set; }

    public int Qty { get; set; }

    public string? Desccription { get; set; }

    public string? Location { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public string? Stage { get; set; }

    public int? Gid { get; set; }

    public string? JobNo { get; set; }

    public string? PartNo { get; set; }

    public bool? ReworkMrb { get; set; }

    public string? QualityStage { get; set; }
}
