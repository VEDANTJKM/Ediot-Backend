using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionRework
{
    public int Id { get; set; }

    public string InsId { get; set; } = null!;

    public string ReworkId { get; set; } = null!;

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public int? ReworkQty { get; set; }

    public int? ReworkCompleteQty { get; set; }
}
