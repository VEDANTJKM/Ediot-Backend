using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Gatepasspreviousdaydetail
{
    public int Pid { get; set; }

    public string Gpno { get; set; } = null!;

    public string? Authorizedperson { get; set; }

    public string? SupplierName { get; set; }

    public DateTime? Date { get; set; }

    public string? Type { get; set; }
}
