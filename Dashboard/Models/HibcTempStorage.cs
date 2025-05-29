using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class HibcTempStorage
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string Licid { get; set; } = null!;

    public string? Lic { get; set; }

    public string? ProductName { get; set; }

    public int? Uom { get; set; }

    public string? LotNumber { get; set; }

    public DateTime? ManufacturingDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Qty { get; set; }
}
