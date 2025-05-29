using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionPlanning
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Machine { get; set; }

    public string? MachineName { get; set; }

    public string? MachineNo { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? Op { get; set; }

    public DateTime? UploadDate { get; set; }

    public DateTime? PlanningStartDate { get; set; }

    public DateTime? PlanningEndDate { get; set; }

    public string? Revision { get; set; }

    public string? OpName { get; set; }

    public string? Status { get; set; }

    public int? JobQty { get; set; }

    public int? OkQty { get; set; }

    public int? RemainingQty { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? CycleTime { get; set; }

    public int? CompletedDay { get; set; }

    public decimal? AssignedQty { get; set; }

    public TimeOnly? PlanningStartTime { get; set; }

    public TimeOnly? PlanningEndTime { get; set; }

    public DateTime? SetupDate { get; set; }

    public DateTime? ProductionDate { get; set; }

    public TimeOnly? SetupDatetime { get; set; }

    public TimeOnly? ProductionTime { get; set; }

    public DateTime? ProductionEndDate { get; set; }

    public DateTime? ProductionStartDate { get; set; }

    public string? SystemName { get; set; }

    public bool? ChangeJob { get; set; }

    public string? ChangeRemark { get; set; }

    public string? ChangeJobnum { get; set; }

    public string? ChangeOp { get; set; }

    public string? ChangeMachineName { get; set; }

    public bool? ChangeJobApproval { get; set; }

    public DateTime? OtherDatetime { get; set; }

    public DateTime? PromiseShipDate { get; set; }

    public DateTime? ResettingDate { get; set; }

    public DateTime? ProductionStartDateResetting { get; set; }

    public bool? ForceClose { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreatedUser { get; set; }
}
