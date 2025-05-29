using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MrsmiscelleneousIssueTbl
{
    public int Id { get; set; }

    public int? IssueId { get; set; }

    public double? TransQty { get; set; }

    public double? IssueQtyCurrentTime { get; set; }

    public DateTime? IssueTimestamp { get; set; }

    public string? IssueBy { get; set; }

    public string? IssueRefference { get; set; }

    public string? IssueLotno { get; set; }

    public string? IssueReason { get; set; }

    public string? IssueRemark { get; set; }

    public string? IssueTo { get; set; }

    public double? BalanceQty { get; set; }
}
