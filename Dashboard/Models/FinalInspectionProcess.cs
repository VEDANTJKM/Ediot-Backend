using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionProcess
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string InspectionId { get; set; } = null!;

    public int? ReworkId { get; set; }

    public string? Process { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? InspectionType { get; set; }

    public DateTime? InspectionDate { get; set; }

    public string? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public int? InspectionQty { get; set; }

    public string? DoneBy { get; set; }

    public string? Stage { get; set; }

    public bool? CkMrb { get; set; }

    public bool? Statuschange { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public string? Qualitystage { get; set; }

    public string? Sampleqty { get; set; }
}
