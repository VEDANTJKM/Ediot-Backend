using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Tempdatatable
{
    public int TenentId { get; set; }

    public int Type { get; set; }

    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public decimal? Count { get; set; }

    public decimal? TotalCount { get; set; }

    public decimal? Percentage { get; set; }
}
