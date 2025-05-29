using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkPoForecast
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? Type { get; set; }

    public string? PoNumber { get; set; }

    public DateTime? PoDate { get; set; }

    public string? PartNumber { get; set; }

    public string? SubPart { get; set; }

    public string? ReferencePart { get; set; }

    public string? Status { get; set; }

    public DateTime? EntryDate { get; set; }

    public decimal? PoQty { get; set; }

    public string? Category { get; set; }

    public string? Sqrmcode { get; set; }

    public string? RevisionType { get; set; }

    public int? RevisionNo { get; set; }

    public string? PoDgRelatedRemarks { get; set; }

    public DateTime? DrawingAvailableDate { get; set; }

    public DateTime? DrawingVerifyDate { get; set; }

    public string? DrawingRemarks { get; set; }

    public string? MaterialRemaks { get; set; }

    public string? SnMadeOutSource { get; set; }

    public string? MaterialRelatedRemark { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public int? SaveBy { get; set; }

    public int? SubmitBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
