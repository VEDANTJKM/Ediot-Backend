using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionStageDatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string InspectionId { get; set; } = null!;

    public string? CurrentDateTime { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? Stage { get; set; }

    public string? Qty { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public string? InspectionType { get; set; }

    public string? Stageno { get; set; }

    public string? Qualitystage { get; set; }
}
