using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class UdaiUdimaster
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int LineId { get; set; }

    public string PartNo { get; set; } = null!;

    public string? SuggestedJobNo { get; set; }

    public string? JobNo { get; set; }

    public int RevisionNo { get; set; }

    public string? UdiRemark { get; set; }

    public DateOnly RequestDate { get; set; }

    public bool? UdidrawingRequired { get; set; }

    public string? Status { get; set; }

    public int? JobConfirmBy { get; set; }

    public string? DenyReson { get; set; }

    public DateTime Timestamp { get; set; }

    public int UserId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? PlanningTimestamp { get; set; }

    public DateTime? UdigenerationTimestamp { get; set; }

    public int? UdigeneratedBy { get; set; }

    public string? Udistring { get; set; }

    public string? UdiMatrixFilePath { get; set; }

    public string? UdiMatrixQr { get; set; }

    public string? UdiMatrixBarcode { get; set; }

    public bool? ApprovedDgAvail { get; set; }

    public string? ApproveDgAvailFilePath { get; set; }

    public DateTime? EngProcessTimestamp { get; set; }

    public int? EngProcessBy { get; set; }

    public DateTime? CloseTimestamp { get; set; }

    public int? ClosedBy { get; set; }

    public string? QualityDoc { get; set; }

    public bool? IsFinal { get; set; }

    public bool? IsErpDown { get; set; }
}
