using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EcnDatabaseFlex
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string EcnNo { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? CustomerPartNumber { get; set; }

    public string? CustomerDrawingNumber { get; set; }

    public string? CustomerDrawingRevision { get; set; }

    public string? CustomerPartRevision { get; set; }

    public string? SswPartName { get; set; }

    public string? SswDrawingRevision { get; set; }

    public string? ChangeRequestedBy { get; set; }

    public string? ChangeType { get; set; }

    public string? StageOfChange { get; set; }

    public string? ReasonForChange { get; set; }

    public string? ChangeDetails { get; set; }

    public string? EngineeringChangeCumApprovalNote { get; set; }

    public string? Feasibility { get; set; }

    public string? RiskAssessment { get; set; }

    public string? ChangeReferenceDocument { get; set; }

    public string? SswSnApproval { get; set; }

    public string? SswFlApproval { get; set; }

    public string? EcnStatus { get; set; }

    public DateTime? EcnReleaseDate { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }

    public bool? Active { get; set; }

    public string? ChangeDetailsExisting { get; set; }

    public string? ChangeDetailsProposed { get; set; }

    public DateTime? SswSnApprovalDate { get; set; }

    public DateTime? SswFlApprovalDate { get; set; }

    public string? FlApprovalDocument { get; set; }

    public string? RemarkForApproval { get; set; }

    public string? OtherStageName { get; set; }

    public string? OtherReasonName { get; set; }

    public string? ZipFile { get; set; }

    public bool? Productprototype { get; set; }

    public bool? Productafterproduction { get; set; }

    public bool? Process { get; set; }
}
