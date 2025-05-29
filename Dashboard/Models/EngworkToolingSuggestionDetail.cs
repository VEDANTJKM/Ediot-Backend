using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkToolingSuggestionDetail
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public int? Mid { get; set; }

    public string? ToolType { get; set; }

    public string? ToolPartName { get; set; }

    public string? ToolPartDescription { get; set; }

    public decimal? ToolRequirementQty { get; set; }

    public decimal? ToolOnHandQty { get; set; }

    public bool? ToolAvaInstore { get; set; }

    public bool? OverrideToolingAvailable { get; set; }

    public bool? IsDeleted { get; set; }
}
