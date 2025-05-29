using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchDatum
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public string? PartNo { get; set; }

    public string? PoNo { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? LineNo { get; set; }

    public string? JobNo { get; set; }

    public bool? Lm { get; set; }

    public int? Qty { get; set; }

    public decimal? WPcs { get; set; }

    public int? Box { get; set; }

    public string? MaterialDetails { get; set; }

    public decimal? TotalWeight { get; set; }

    public string? BoxType { get; set; }

    public decimal? BoxWeight { get; set; }

    public bool? SupervisorApproval { get; set; }

    public bool? PurchaserVerification { get; set; }

    public bool? FinanceApproval { get; set; }

    public string? PartDesc { get; set; }

    public decimal? BoxLength { get; set; }

    public decimal? BoxHeight { get; set; }

    public decimal? BoxWidth { get; set; }

    public string? PackingDetailsManualorSuggested { get; set; }
}
