using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ToolTrialShiftDatum
{
    public int Id { get; set; }

    public int? Tid { get; set; }

    public int? Pid { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? Currentdate { get; set; }

    public int? Shift { get; set; }

    public int? Qty { get; set; }

    public string? Remark { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public string? Operatorname { get; set; }

    public decimal? Cycletime { get; set; }
}
