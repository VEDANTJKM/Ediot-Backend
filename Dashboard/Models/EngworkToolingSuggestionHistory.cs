using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkToolingSuggestionHistory
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public int Mid { get; set; }

    public string? SpecialToolRequired { get; set; }

    public string? ToolingPartName { get; set; }

    public string? ToolingOnHandQty { get; set; }

    public string? ToolAvailableinStore { get; set; }

    public string? ToolingRemark { get; set; }

    public string? OverrideToolingAvaCheckMark { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public bool? IsSavedBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
