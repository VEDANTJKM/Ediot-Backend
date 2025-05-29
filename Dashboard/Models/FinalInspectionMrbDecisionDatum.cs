using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionMrbDecisionDatum
{
    public int Id { get; set; }

    public int Iid { get; set; }

    public int Pid { get; set; }

    public string Mrbdecision { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string? Time { get; set; }

    public string OkQty { get; set; } = null!;

    public string RejectQty { get; set; } = null!;

    public string Remark { get; set; } = null!;

    public bool Active { get; set; }

    public bool Deleted { get; set; }
}
