using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionSetupDtl
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int SetupId { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? RevNo { get; set; }

    public int? Op { get; set; }

    public string? Shift { get; set; }

    public int? PersonId { get; set; }

    public string? Setup { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? CycleTime { get; set; }

    public decimal? LoadingTime { get; set; }

    public decimal? OtherTime { get; set; }

    public decimal? OkQty { get; set; }

    public decimal? RejectQty { get; set; }

    public decimal? NonConQty { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? RemainingQty { get; set; }

    public decimal? TimeForTotalQty { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Status { get; set; }

    public string? Machine { get; set; }

    public string? MachineNo { get; set; }

    public string? MachineName { get; set; }

    public DateTime? Uploaddate { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public decimal? SetupTimeTotal { get; set; }

    public string? RemarkForMachine { get; set; }

    public string? RemarkForJob { get; set; }

    public decimal? ForceQty { get; set; }

    public bool? ForceClose { get; set; }

    public decimal? LotQty { get; set; }

    public string? Type { get; set; }

    public DateOnly? PlanningDate { get; set; }

    public DateOnly? ProductionDate { get; set; }

    public DateOnly? ActualUpload { get; set; }
}
