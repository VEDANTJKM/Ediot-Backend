using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchInventoryStockLog
{
    public int Id { get; set; }

    public int? Pid { get; set; }

    public int? Stock { get; set; }

    public int? TransactionQty { get; set; }

    public string? Logs { get; set; }

    public DateTime? DateandTime { get; set; }

    public string? Remark { get; set; }
}
