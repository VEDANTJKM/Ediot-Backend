using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionStageMaster
{
    public int Id { get; set; }

    public int? Stage { get; set; }

    public string? StagePartStatus { get; set; }
}
