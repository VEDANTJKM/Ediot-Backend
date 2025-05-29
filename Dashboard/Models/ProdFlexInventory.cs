using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProdFlexInventory
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string InventoryId { get; set; } = null!;

    public DateOnly? InventoryDate { get; set; }

    public string? MachineName { get; set; }

    public string? MachineNo { get; set; }

    public string? PartName { get; set; }

    public string? JobNumber { get; set; }

    public decimal? WeightKg { get; set; }

    public decimal? Feet { get; set; }

    public string? InventoryTime { get; set; }

    public decimal? CurrentStock { get; set; }

    public decimal? ReelStock { get; set; }

    public string? Status { get; set; }

    public bool? JobToMesProduction { get; set; }

    public bool? JobToMesQuality { get; set; }

    public bool? JobToInventory { get; set; }

    public DateOnly? IssueDate { get; set; }

    public string? IssueTime { get; set; }

    public string? IssueMachineName { get; set; }

    public string? IssueMachineNo { get; set; }

    public decimal? IssueFeet { get; set; }

    public string? PartNameForIssue { get; set; }

    public string? AfcMsmJobNo { get; set; }

    public string? AfcOperator { get; set; }

    public string? ReelIssueShift { get; set; }

    public bool? IssueMaterial { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public string? ReturnTime { get; set; }

    public decimal? ReturnWeightKg { get; set; }

    public decimal? ReturnFeet { get; set; }

    public bool? ReelReturnShift { get; set; }

    public string? ResponsibleMsmOperator { get; set; }

    public string? Comments { get; set; }

    public bool? ReturnMaterial { get; set; }

    public DateOnly? ReelIssueDate { get; set; }

    public string? ReelIssueTime { get; set; }

    public string? AfcMsmMachineName { get; set; }

    public string? AfcMsmMachineNo { get; set; }

    public decimal? IssueWeightKg { get; set; }
}
