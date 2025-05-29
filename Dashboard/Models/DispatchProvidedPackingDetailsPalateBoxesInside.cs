using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchProvidedPackingDetailsPalateBoxesInside
{
    public int Id { get; set; }

    public int? Pid { get; set; }

    public string? BoxesInside { get; set; }

    public int? TotalBoxCount { get; set; }

    public int? PalletId { get; set; }
}
