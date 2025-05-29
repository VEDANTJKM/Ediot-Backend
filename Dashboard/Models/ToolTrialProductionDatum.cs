using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ToolTrialProductionDatum
{
    public int Id { get; set; }

    public int? Tid { get; set; }

    public string? JobNo { get; set; }

    public string? PartNo { get; set; }

    public string? LotNo { get; set; }

    public string? MaterialNo { get; set; }

    public DateTime? Currentdate { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public double? WorkPieceCuttingDiameter { get; set; }

    public double? DepthOfCut { get; set; }

    public double? WidthOfCut { get; set; }

    public string? SupervisorName { get; set; }

    public string? ProgrammerName { get; set; }

    public string? Rigidity { get; set; }

    public string? Holder { get; set; }

    public string? CoolantType { get; set; }

    public string? CoolantMethod { get; set; }

    public string? Savesubmit { get; set; }

    public bool? Jobcomplete { get; set; }

    public double? FeedRate { get; set; }

    public double? CuttingSpeedOrrpm { get; set; }
}
