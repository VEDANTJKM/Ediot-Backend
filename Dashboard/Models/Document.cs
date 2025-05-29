using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Document
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string DocumentType { get; set; } = null!;

    public int DocumentId { get; set; }

    public string? DocumentTitle { get; set; }

    public string? DocumentName { get; set; }

    public string? Purpose { get; set; }

    public string? Scope { get; set; }

    public string? Responsibilities { get; set; }

    public string? Definitions { get; set; }

    public string? Procedures { get; set; }

    public string? AssociatedDocuments { get; set; }

    public int? RevisionLog { get; set; }

    public string? AssociatedDocumentId { get; set; }

    public int? Rev { get; set; }

    public string? FileSubjectToApprovalProcess { get; set; }

    public string? RevSecParaChanged { get; set; }

    public string? RevChangeMode { get; set; }

    public string? RevChangedBy { get; set; }

    public DateTime? RevChangedDate { get; set; }

    public string? RevTrainingRequired { get; set; }

    public DateTime? RevTrainingCompletedOn { get; set; }

    public int? AttachmentId { get; set; }

    public int? PropertyElectricalId { get; set; }

    public int? PropertyApprovalId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? DocumentIdTitle { get; set; }

    public string? Form { get; set; }

    public string? Notes { get; set; }

    public string? ProceDure { get; set; }

    public string? WorkInstruction { get; set; }

    public string? EcnNumber { get; set; }

    public string? EcnTitle { get; set; }

    public DateTime? EcnDateNeeded { get; set; }

    public string? CustomerApprovalRequired { get; set; }

    public string? CustomerNotificationRequired { get; set; }

    public string? PartDescriptionOrName { get; set; }

    public string? PartNumber { get; set; }

    public string? DrawingNumber { get; set; }

    public string? CustomerPartNumber { get; set; }

    public int? CurrentRev { get; set; }

    public int? NewRev { get; set; }

    public string? DescriptionOfChange { get; set; }

    public string? ReasonForChange { get; set; }

    public int? EcnWillChangeNo { get; set; }

    public string? InstructionForEcnImplementation { get; set; }

    public DateTime? ImplementationDate { get; set; }

    public string? Status { get; set; }

    public DateTime? UpdateDateDoc { get; set; }

    public string? UpdateBy { get; set; }
}
