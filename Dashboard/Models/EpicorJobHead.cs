using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EpicorJobHead
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? Company { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? Rev { get; set; }

    public string? DrawNum { get; set; }

    public string? PartDescription { get; set; }

    public decimal? JobQty { get; set; }

    public bool? JobClosed { get; set; }

    public DateTime? ClosedDate { get; set; }

    public bool? JobCompleted { get; set; }

    public DateTime? CompletedDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? TotalDays { get; set; }

    public DateTime? Uploaddate { get; set; }

    public string? ProdCode { get; set; }

    public DateOnly? CreateDate { get; set; }
}
