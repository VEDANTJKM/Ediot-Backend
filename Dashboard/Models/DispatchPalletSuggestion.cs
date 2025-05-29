using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchPalletSuggestion
{
    public int Id { get; set; }

    public int PackSlipId { get; set; }

    public string PalletSize { get; set; } = null!;

    public string PalletCount { get; set; } = null!;

    public string? BoxType { get; set; }

    public bool IsSuggested { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? BoxCount { get; set; }
}
