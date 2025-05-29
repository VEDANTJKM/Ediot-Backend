using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TpmNonconReceiptIssue
{
    public int ReceiptNo { get; set; }

    public int InitiatiorId { get; set; }

    public string? Status { get; set; }

    public int EpoNo { get; set; }

    public int ChallanNo { get; set; }

    public int InvoiceNo { get; set; }

    public string? ReceiveDate { get; set; }

    public int RequestedQty { get; set; }

    public int TransactionQty { get; set; }

    public int RemainingQty { get; set; }

    public string? Remark { get; set; }

    public string? IssueTo { get; set; }

    public int IssueQty { get; set; }

    public string? IssueDate { get; set; }

    public string? IssueStatus { get; set; }
}
