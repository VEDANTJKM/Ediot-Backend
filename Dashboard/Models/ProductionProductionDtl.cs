using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionProductionDtl
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public int SetupId { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? RevNo { get; set; }

    public int? Op { get; set; }

    public string? Shift { get; set; }

    public decimal? CycleTime { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? LoadingTime { get; set; }

    public decimal? OkQty { get; set; }

    public decimal? RejectQty { get; set; }

    public decimal? NonConQty { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? RemainingQty { get; set; }

    public string? Status { get; set; }

    public DateTime? Starttime { get; set; }

    public string? Setup { get; set; }

    public string? PersonId { get; set; }

    public string? Machine { get; set; }

    public string? MachineNo { get; set; }

    public string? MachineName { get; set; }

    public decimal? LotQty { get; set; }

    public string? Type { get; set; }

    public DateOnly? StartDate { get; set; }

    public decimal? OtherTime { get; set; }

    public decimal? ProductionTime { get; set; }

    public DateOnly? PlanningDate { get; set; }

    public DateOnly? SetupDate { get; set; }

    public bool? ShiftEntry { get; set; }

    public bool? BackEntry { get; set; }

    public DateOnly? ActualProductionDate { get; set; }

    public string? ActualProductionTime { get; set; }

    public DateTime? StartTimeForShift { get; set; }

    public TimeOnly? StartTime { get; set; }

    public DateTime? ProductionStartDate { get; set; }

    public DateTime? ProductionEndDate { get; set; }
}
