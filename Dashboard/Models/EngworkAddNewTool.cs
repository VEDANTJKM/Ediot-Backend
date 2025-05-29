using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkAddNewTool
{
    public int Id { get; set; }

    public string? ToolName { get; set; }

    public string? PartDescription { get; set; }

    public string? ToolType { get; set; }

    public string? TotalCorner { get; set; }

    public decimal? PerCornerQty { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? PerPartQty { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public bool? IsSavedBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
