using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TicketGenerationProcess
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string TicketId { get; set; } = null!;

    public string? TicketGeneratorName { get; set; }

    public string? EmailId { get; set; }

    public string? FromDepartment { get; set; }

    public string? ToDepartment { get; set; }

    public string? Requestregarding { get; set; }

    public string? Remark { get; set; }

    public bool? NeedApplication { get; set; }

    public string? ApplicationName { get; set; }

    public string? ApplicaitonScope { get; set; }

    public string? ApplicationPurpose { get; set; }

    public string? ResposibleUser { get; set; }

    public string? HowItWorks { get; set; }

    public DateTime? UploadDate { get; set; }

    public DateTime? DeadlineDate { get; set; }

    public string? ServerRequirement { get; set; }

    public string? Attachment { get; set; }

    public string? Status { get; set; }

    public string? WhatAreYouUsingNow { get; set; }

    public string? ApplicationType { get; set; }

    public string? WhichDepartmentMonitoring { get; set; }

    public string? DatabaseImportance { get; set; }

    public string? ResponsibleDepartment { get; set; }

    public string? ApplicationLiability { get; set; }

    public DateTime? MockDueDate { get; set; }

    public DateTime? FinalDate { get; set; }

    public string? RetentionData { get; set; }

    public bool? Approval { get; set; }

    public int? UserId { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? TypeOfTicket { get; set; }

    public string? RemarkCompletion { get; set; }

    public string? RemarkCancel { get; set; }

    public DateTime? CompletionDate { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? ApprovalRemark { get; set; }

    public string? ItCloseRemark { get; set; }

    public string? UserCloseRemark { get; set; }

    public DateTime? ItCloseDate { get; set; }

    public DateTime? UserCloseDate { get; set; }
}
