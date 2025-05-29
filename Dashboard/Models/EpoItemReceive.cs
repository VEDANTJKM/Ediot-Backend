using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EpoItemReceive
{
    public int Id { get; set; }

    public int EpoNo { get; set; }

    public int LineNo { get; set; }

    public int Pid { get; set; }

    public int? OrderQty { get; set; }

    public int? ReceivedQty { get; set; }

    public int? RemainingQty { get; set; }

    public int? TransactionQty { get; set; }

    public string? InvoiceNo { get; set; }

    public string? ChallanNo { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? ReceivedBy { get; set; }
}
