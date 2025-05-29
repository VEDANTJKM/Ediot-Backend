using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MrsreturnReturnTransactionTbl
{
    public int Id { get; set; }

    public int? ReturnId { get; set; }

    public double? ReturnQtyCurrentTime { get; set; }

    public double? ReturnTransQty { get; set; }

    public string? ReturnRefference { get; set; }

    public string? ReturnLotno { get; set; }

    public string? ReturnReason { get; set; }

    public DateTime? ReturnTimestamp { get; set; }

    public string? ReturnBy { get; set; }

    public DateTime? Timestamp { get; set; }

    public double? ReturnedQty { get; set; }

    public string? ReturnRemark { get; set; }

    public string? ReturnPurpose { get; set; }

    public double? BalanceQty { get; set; }
}
