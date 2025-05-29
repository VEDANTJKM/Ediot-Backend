using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationStandrdizedBin
{
    public int Id { get; set; }

    public string? JobNo { get; set; }

    public string? PartNumber { get; set; }

    public string? RevNo { get; set; }

    public int? OpSeq { get; set; }

    public string? OpProcess { get; set; }

    public string? Machine { get; set; }

    public bool? DontHaveJobNo { get; set; }

    public string? Remark { get; set; }

    public DateTime? TimeStart { get; set; }

    public DateTime? TimeEnd { get; set; }

    public bool? MatchSetupSheet { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? Status { get; set; }

    public int? UserId { get; set; }

    public bool? IsAccountable { get; set; }

    public string? SupervisiorRemark { get; set; }

    public TimeOnly? DurationHoursMin { get; set; }
}
