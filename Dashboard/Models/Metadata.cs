using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Metadata
{
    public int Id { get; set; }

    public string RequisitionNo { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? ProblemSolved { get; set; }

    public string? Status { get; set; }

    public string? YourName { get; set; }

    public string Shift { get; set; } = null!;

    public string? RequestedName { get; set; }

    public string? MachineSystemProcessUnit { get; set; }

    public string? TypeOfMaintanance { get; set; }

    public string? ProblemType { get; set; }

    public string? BreakdownProblem { get; set; }

    public DateOnly? BreakdownDate { get; set; }

    public string? BreakdownTime { get; set; }

    public string? BreakdownTime2 { get; set; }

    public string? BreakdownReason { get; set; }

    public DateOnly? RepairstartDate { get; set; }

    public string? RepairstartTime { get; set; }

    public string? CommentOnWaitingToBreakdown { get; set; }

    public string? RepairActionTaken { get; set; }

    public DateOnly? RepairCompletionDate { get; set; }

    public string? RepairCompletionTime { get; set; }

    public string? CommentOnTotalTimeConsumedInBreakdown { get; set; }

    public string? FloorShutdownWeeklyoffHoliday { get; set; }

    public decimal? TimeTakenToAttenHr { get; set; }

    public decimal? TimeTakenToAttendMin { get; set; }

    public decimal? TimeTakenToRepairHr { get; set; }

    public decimal? TimeTakenToRepairMin { get; set; }

    public decimal? TotalTimeHr { get; set; }

    public decimal? TotalTimeMin { get; set; }

    public decimal? AdjustmentTimeTakenToAttendHr { get; set; }

    public decimal? AdjustmentTimeTakenToAttenMin { get; set; }

    public string? CommentForTimeAdjustment { get; set; }

    public string? PartName { get; set; }

    public int? Quantity { get; set; }

    public string? Cost { get; set; }

    public string? PartName1 { get; set; }

    public int? Quantity1 { get; set; }

    public string? Cost1 { get; set; }

    public string? PartName2 { get; set; }

    public int? Quantity2 { get; set; }

    public string? Cost2 { get; set; }

    public decimal? MachineDowntimeCost { get; set; }

    public decimal? TotalSparePartCost { get; set; }

    public decimal? TotalCost { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? EmailAddress { get; set; }

    public string? BreakdownMonth { get; set; }

    public string? Remarks { get; set; }

    public string? Approval { get; set; }

    public string? Pending { get; set; }

    public string? Closed { get; set; }

    public string? Usertype { get; set; }

    public string? MachineSystemProcessUnitNumber { get; set; }

    public string? Reasonfornotapprove { get; set; }

    public decimal? Rstime { get; set; }

    public decimal? Rstimem { get; set; }

    public decimal? Rctime { get; set; }

    public decimal? Rctimem { get; set; }

    public decimal? Rtotal { get; set; }

    public decimal? Rtotalm { get; set; }

    public decimal? AdjustmentTimeTakenToRepairHr { get; set; }

    public decimal? AdjustmentTimeTakenToRepairMin { get; set; }

    public decimal? TotalAdjustHr { get; set; }

    public decimal? TotalAdjustMin { get; set; }

    public decimal? TotalRepairHr { get; set; }

    public decimal? TotalRepairMin { get; set; }

    public string? CommentForAdjustRepair { get; set; }

    public int? Userid { get; set; }

    public string? BreakdownDetailChangeReason { get; set; }

    public string? RepairDetailChangeReason { get; set; }

    public string? BreakdownDetailChange { get; set; }

    public DateTime? OldBreakdownDate { get; set; }

    public string? OldBreakdownTime { get; set; }

    public DateTime? UploadDate { get; set; }
}
