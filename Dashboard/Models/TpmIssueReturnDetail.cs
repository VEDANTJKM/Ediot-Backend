using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TpmIssueReturnDetail
{
    public int InitiatorId { get; set; }

    public string? Reqno { get; set; }

    public string? InitiatorName { get; set; }

    public string? Status { get; set; }

    public string? Department { get; set; }

    public string? ItemName { get; set; }

    public string? ItemDescription { get; set; }

    public string? Uom { get; set; }

    public string? IssueTo { get; set; }

    public string? ReturnFrom { get; set; }

    public int OrderQty { get; set; }

    public int IssueQty { get; set; }

    public int ReturnQty { get; set; }

    public int RemainingQty { get; set; }

    public string? RequestDate { get; set; }

    public string? IssueDate { get; set; }

    public string? ReturnDate { get; set; }

    public bool ItemIssued { get; set; }

    public bool ItemReturned { get; set; }

    public string? Entrytype { get; set; }

    public string? PartUsage { get; set; }

    public string? Purpose { get; set; }

    public int BalancedQty { get; set; }
}
