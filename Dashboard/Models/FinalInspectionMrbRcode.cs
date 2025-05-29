using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionMrbRcode
{
    public int Id { get; set; }

    public int? Pid { get; set; }

    public string? Rtaxt { get; set; }

    public string? Remark { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public string? Desicion { get; set; }

    public string? Rcode { get; set; }

    public string? SubQty { get; set; }

    public string? DesicionSubQty { get; set; }

    public int? Mrbsubqty { get; set; }

    public int? Reject { get; set; }

    public int? Accept { get; set; }

    public int? Rework { get; set; }

    public int? Sorting { get; set; }

    public int? Resorting { get; set; }

    public int? Deviation { get; set; }

    public int? Reworkinmrb { get; set; }

    public int? Remeasured { get; set; }

    public int? Split { get; set; }

    public int? Hold { get; set; }
}
