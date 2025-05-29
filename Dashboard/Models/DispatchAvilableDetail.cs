using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchAvilableDetail
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public string? SuggestedPallets { get; set; }

    public string? PalletsCounts { get; set; }

    public string? EntryTypes { get; set; }
}
