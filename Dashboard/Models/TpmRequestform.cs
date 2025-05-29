using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TpmRequestform
{
    public int InitiatorId { get; set; }

    public string? Reqno { get; set; }

    public string? InitiatorName { get; set; }

    public string? Status { get; set; }

    public string? Department { get; set; }

    public string? ItemName { get; set; }

    public string? ItemType { get; set; }

    public string? ItemDescription { get; set; }

    public int RequestedQty { get; set; }

    public string? Uom { get; set; }

    public string? DueDate { get; set; }

    public string? Attachment { get; set; }

    public string? SupplierName { get; set; }

    public string? Remark { get; set; }

    public string? Purpose { get; set; }

    public string? PartUsage { get; set; }

    public string? ReqType { get; set; }

    public string? CurrentDateTime { get; set; }

    public string? IsSaved { get; set; }

    public string? Review { get; set; }

    public string? ReviewDate { get; set; }

    public string? VoidReason { get; set; }
}
