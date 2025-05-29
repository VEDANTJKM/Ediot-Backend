using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkPoForecastHistory
{
    public int Id1 { get; set; }

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

    public bool? IsRedline { get; set; }

    public int? RevisionNo { get; set; }

    public string? PoDgRelatedRemarks { get; set; }

    public DateTime? DrawingAvailableDate { get; set; }

    public DateTime? DrawingVerifyDate { get; set; }

    public string? DrawingRemarks { get; set; }

    public string? MaterialRemaks { get; set; }

    public string? SnMadeOutSource { get; set; }

    public string? MaterialRelatedRemark { get; set; }

    public string? MafiaStatus { get; set; }

    public bool? IsDeleted1 { get; set; }

    public bool? IsSaved1 { get; set; }

    public bool? IsSubmited1 { get; set; }

    public int? SaveBy { get; set; }

    public int? SubmitBy { get; set; }

    public DateTime? SaveTimestamp1 { get; set; }

    public DateTime? SubmitTimestamp1 { get; set; }

    public int Id { get; set; }

    public int Rid { get; set; }

    public string? Opsequence { get; set; }

    public string? Process { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public bool? IsSavedBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
