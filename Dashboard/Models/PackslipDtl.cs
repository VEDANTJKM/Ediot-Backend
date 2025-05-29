using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PackslipDtl
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? LabelType { get; set; }

    public string? Packnum { get; set; }

    public string? Lotnum { get; set; }

    public string? Totalboxqty { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Masterqty { get; set; }
}
