using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Tblbin
{
    public int TenentId { get; set; }

    public int BinId { get; set; }

    public int? MyComLocId { get; set; }

    public string Bindesc1 { get; set; } = null!;

    public string? Bindesc2 { get; set; }

    public string? Binremarks { get; set; }

    public bool? BinReqMaintenace { get; set; }

    public string? Active { get; set; }

    public long? CrupId { get; set; }
}
