using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PurreqInvoiceViewdetail
{
    public string Reqno { get; set; } = null!;

    public int Id { get; set; }

    public int LineNo { get; set; }

    public int Pid { get; set; }

    public string Payslipno { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public string? ChallanNo { get; set; }

    public string? Itemname { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? SuppName { get; set; }

    public int? Itemqty { get; set; }

    public int? RemainingQty { get; set; }

    public int? ReceivedQty { get; set; }

    public int? TransactionQty { get; set; }

    public string? Remark { get; set; }

    public int? Payslipnonew { get; set; }

    public decimal? ItemqtyNew { get; set; }

    public decimal? RemainingQtyNew { get; set; }

    public decimal? ReceivedQtyNew { get; set; }

    public decimal? TransactionQtyNew { get; set; }

    public DateTime? IssueDate { get; set; }

    public string? IssueBy { get; set; }

    public string? IssueStatus { get; set; }

    public decimal? IssueIteQty { get; set; }
}
