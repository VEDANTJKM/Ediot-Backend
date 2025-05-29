using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionEcrDatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string EcrId { get; set; } = null!;

    public string? ProductionId { get; set; }

    public string? JobNo { get; set; }

    public string? PartNumber { get; set; }

    public string? OpNo { get; set; }

    public string? RevNo { get; set; }

    public string? Subject { get; set; }

    public DateTime? EcrDate { get; set; }

    public string? EcnId { get; set; }

    public bool? Dimentional { get; set; }

    public bool? Asthetical { get; set; }

    public bool? Functional { get; set; }
}
