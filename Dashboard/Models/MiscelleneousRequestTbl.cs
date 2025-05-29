using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MiscelleneousRequestTbl
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int LineId { get; set; }

    public string? RequestNo { get; set; }

    public string UserId { get; set; } = null!;

    public string? InitiatorId { get; set; }

    public string? InitiatorName { get; set; }

    public string? DepartmentName { get; set; }

    public DateOnly? ReqDate { get; set; }

    public string? RequestedPartNo { get; set; }

    public string RequestedPartDesc { get; set; } = null!;

    public string? WhereUsePartNo { get; set; }

    public double? ReqQty { get; set; }

    public double? IssueQty { get; set; }

    public string? Uom { get; set; }

    public string? Purpose { get; set; }

    public DateTime? Timestamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Status { get; set; }

    public double? ReturnQty { get; set; }

    public bool? IsFinal { get; set; }

    public string? VoidResoan { get; set; }
}
