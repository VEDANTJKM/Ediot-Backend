using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MrsTempReturnMiscelleneousRequestTbl
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? LineId { get; set; }

    public string UserId { get; set; } = null!;

    public string? InitiatorId { get; set; }

    public string? InitiatorName { get; set; }

    public string? DepartmentName { get; set; }

    public string? SubDepartment { get; set; }

    public DateOnly? ReturnReqDate { get; set; }

    public double? ReturnReqQty { get; set; }

    public double? ReturnQty { get; set; }

    public string? ReturnPartNo { get; set; }

    public string? ReturnPartDesc { get; set; }

    public string? WhereUsePartNo { get; set; }

    public string? Uom { get; set; }

    public string Purpose { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public string? Status { get; set; }
}
