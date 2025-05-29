using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionFinalDatum
{
    public int Id { get; set; }

    public string SetupId { get; set; } = null!;

    public string? Shift { get; set; }

    public string? Person { get; set; }

    public string? Machine { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? Op { get; set; }

    public string? Rev { get; set; }

    public DateTime? SetupStart { get; set; }

    public DateTime? SetupContinue { get; set; }

    public DateTime? SetupEnd { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? CycleTime { get; set; }

    public decimal? LoadingTime { get; set; }

    public decimal? OtherTime { get; set; }

    public decimal? OkQty { get; set; }

    public decimal? RejectQty { get; set; }

    public decimal? NonConQty { get; set; }

    public DateTime? Uploaddate { get; set; }
}
