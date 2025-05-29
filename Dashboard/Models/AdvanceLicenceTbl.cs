using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class AdvanceLicenceTbl
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int LineId { get; set; }

    public DateOnly? RmIssueDate { get; set; }

    public string? RmJobNo { get; set; }

    public string? RmPartNo { get; set; }

    public string? RmDescription { get; set; }

    public string? RmLotNo { get; set; }

    public string? RmFgPartNo { get; set; }

    public string? UploadedName { get; set; }

    public DateTime? UploadedDate { get; set; }

    public bool? IsFinal { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RmOperation { get; set; }

    public decimal? QtyRejectedInNumber { get; set; }

    public decimal? RejectedQtyInKg { get; set; }

    public decimal? WasteScrap { get; set; }

    public decimal? OkQtyKg { get; set; }

    public decimal? OkQtyPc { get; set; }

    public decimal? IssuedQtyKgActual { get; set; }

    public string? JobQty { get; set; }

    public decimal? OpWeight { get; set; }

    public decimal? PerOperationOkQty { get; set; }

    public decimal? PerPartQty { get; set; }

    public decimal? ChipWtProducedKg { get; set; }

    public string? RemarkForOkqty { get; set; }

    public string? RmOperationName { get; set; }

    public string? ApproxIssueQtyKg { get; set; }

    public string? Binno { get; set; }

    public string? PerPartInch { get; set; }

    public string? IssuedQtyInchActual { get; set; }
}
