using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ToolTrialDatum
{
    public int Id { get; set; }

    public string? MachineNo { get; set; }

    public string? OperationType { get; set; }

    public string? MachineType { get; set; }

    public string? ToolName { get; set; }

    public string? Description { get; set; }

    public string? Make { get; set; }

    public decimal? InsertCostPerPiece { get; set; }

    public string? HourlyMachineCost { get; set; }

    public string? TotalAnnualPieces { get; set; }

    public string? MctimeToolCost { get; set; }

    public int? Toolcost { get; set; }

    public string? ToolcostPcs { get; set; }

    public DateTime? CurrentDate { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public string? Supplier { get; set; }

    public int? ToolQty { get; set; }

    public string? Remark { get; set; }

    public string? Buttonvalue { get; set; }

    public string? Commentfromuser { get; set; }

    public string? ActualMachine { get; set; }

    public string? ActualMachineNo { get; set; }
}
