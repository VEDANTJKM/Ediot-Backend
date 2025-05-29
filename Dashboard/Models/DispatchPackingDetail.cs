using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchPackingDetail
{
    public int Id { get; set; }

    public string PackslipNo { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public string? Category { get; set; }

    public DateTime? Date { get; set; }

    public bool? PllateDision { get; set; }
}
