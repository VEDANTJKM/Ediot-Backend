using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchInventoryStock
{
    public int Id { get; set; }

    public string? PalletType { get; set; }

    public int? Stock { get; set; }

    public string? Remark { get; set; }

    public decimal? PalletAdditionalWeight { get; set; }
}
