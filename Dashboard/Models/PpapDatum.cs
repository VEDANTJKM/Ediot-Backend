using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PpapDatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string PpapNo { get; set; } = null!;

    public string? SswPartNo { get; set; }

    public string? SswPartName { get; set; }

    public string? CustPartNo { get; set; }

    public string? CustPartName { get; set; }

    public string? ReasonForSubmission { get; set; }

    public string? SubmissionLevel { get; set; }

    public DateTime? PpapUploadDate { get; set; }

    public string? Remark { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? CustomerPpapStatus { get; set; }

    public DateTime? ApproveDate { get; set; }

    public DateTime? NotApproveDate { get; set; }

    public DateTime? RejectedDate { get; set; }

    public DateTime? ReviseDate { get; set; }

    public string? PpapAttachment { get; set; }

    public string? PpapUpdateHistory { get; set; }

    public DateTime? PpapUpdateDate { get; set; }

    public string? SswDrawingNo { get; set; }

    public string? CustDrawingNo { get; set; }

    public string? ReasonForNotApprove { get; set; }

    public string? EndCustomer { get; set; }

    public string? OtherReason { get; set; }

    public string? ReQualificationYear { get; set; }

    public DateTime? ReQualificationDate { get; set; }

    public bool? ReQualificationRequired { get; set; }

    public int? ReviceId { get; set; }
}
