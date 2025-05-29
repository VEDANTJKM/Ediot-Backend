using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionDeviationReport
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string DeviationId { get; set; } = null!;

    public string? ProductionId { get; set; }

    public string? JobNo { get; set; }

    public string? PartNumber { get; set; }

    public string? PoForecast { get; set; }

    public decimal? QtyForDeviation { get; set; }

    public string? DescriptionOfNonconformance { get; set; }

    public string? RootCause { get; set; }

    public string? DeviationBy { get; set; }

    public DateTime? DeviationDate { get; set; }

    public decimal? Quntity { get; set; }

    public string? RevNo { get; set; }

    public string? OpNo { get; set; }

    public string? Status { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
