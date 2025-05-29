using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProdcutionReportCnc
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string ProductionId { get; set; } = null!;

    public string? JobNumber { get; set; }

    public string? PartNumber { get; set; }

    public string? RevNo { get; set; }

    public string? OpNo { get; set; }

    public string? MachineName { get; set; }

    public string? MachineNo { get; set; }

    public DateTime? UploadDate { get; set; }

    public DateTime? ProductionDate { get; set; }

    public string? Shift { get; set; }

    public string? Operator { get; set; }

    public bool? DeviationRequired { get; set; }

    public bool? RequestForEcr { get; set; }

    public bool? Mafia { get; set; }

    public bool? Opd { get; set; }

    public bool? OperationSequence { get; set; }

    public decimal? OkQty { get; set; }

    public decimal? RejectQty { get; set; }

    public decimal? NonConfQty { get; set; }

    public string? ReasonForRejection { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? PlanTime { get; set; }

    public decimal? StdSetupTime { get; set; }

    public decimal? StdCycleTime { get; set; }

    public decimal? ActualSetupTime { get; set; }

    public decimal? ActualCycleTime { get; set; }

    public decimal? LoadingTime { get; set; }

    public decimal? NonProductiveTime { get; set; }

    public decimal? TotalProductionTime { get; set; }

    public string? NonProductiveCheckPerson { get; set; }

    public bool? SetupBinFixuring { get; set; }

    public decimal? LotQty { get; set; }

    public string? OpDone { get; set; }

    public string? Status { get; set; }

    public string? Programmer { get; set; }
}
