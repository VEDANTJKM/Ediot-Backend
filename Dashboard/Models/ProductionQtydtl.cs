using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionQtydtl
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string? JobNum { get; set; }

    public int? OpNo { get; set; }

    public decimal? Qty { get; set; }

    public string? Reason { get; set; }

    public string? TypeOfQty { get; set; }

    public string? Shift { get; set; }

    public string? Operator { get; set; }

    public string? Setup { get; set; }

    public DateTime? Uploaddate { get; set; }

    public string? Machine { get; set; }

    public DateTime? ActualDate { get; set; }

    public int? MultipleEntriesDropdown { get; set; }
}
