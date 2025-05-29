using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DayClose
{
    public int Id { get; set; }

    public int TenentId { get; set; }

    public int UserId { get; set; }

    public string TrmId { get; set; } = null!;

    public int ShiftId { get; set; }

    public DateTime Date { get; set; }

    public decimal? OpAmt { get; set; }

    public decimal? ShiftSales { get; set; }

    public decimal? ShiftReturn { get; set; }

    public decimal? ShiftPurchase { get; set; }

    public decimal? ShiftCih { get; set; }

    public decimal? VoucharAmt { get; set; }

    public decimal? ExpAmt { get; set; }

    public decimal? ChequeAmt { get; set; }

    public decimal? Amtdelivered { get; set; }

    public int? DeliveredTo { get; set; }

    public decimal? UndeliverdAmt { get; set; }

    public string? RefNo { get; set; }

    public string? Notes { get; set; }

    public string? UploadDate { get; set; }

    public string? Uploadby { get; set; }

    public string? SyncDate { get; set; }

    public string? Syncby { get; set; }

    public int? SynId { get; set; }

    public int? ShiftStutas { get; set; }

    public int? Employee { get; set; }
}
