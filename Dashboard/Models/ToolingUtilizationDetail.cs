using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ToolingUtilizationDetail
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int? TransactionId { get; set; }

    public string? ToolType { get; set; }

    public string? ToolName { get; set; }

    public int? OrderQty { get; set; }

    public int? QtyMove { get; set; }

    public string? TransactionType { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? TransactionBy { get; set; }

    public string? MachineType { get; set; }

    public string? Status { get; set; }

    public int? UsedQty { get; set; }

    public int? UnusedQty { get; set; }

    public string? JobNo { get; set; }

    public string? PartNo { get; set; }

    public string? Rev { get; set; }
}
