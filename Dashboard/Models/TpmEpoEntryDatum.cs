using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TpmEpoEntryDatum
{
    public int InitiatorId { get; set; }

    public string? ReqNo { get; set; }

    public string? InitiatorName { get; set; }

    public string? ItemName { get; set; }

    public int ItemQty { get; set; }

    public string? TpmEpoEntryDataStatus { get; set; }

    public string? TpmRequestformStatus { get; set; }

    public string? EpoNo { get; set; }

    public string? EpoStatus { get; set; }

    public int LineNo { get; set; }

    public string? SupplierName { get; set; }

    public string? EpoAttachment { get; set; }

    public string? EpoEntryDatetime { get; set; }

    public string? EpoApproveStatus { get; set; }
}
