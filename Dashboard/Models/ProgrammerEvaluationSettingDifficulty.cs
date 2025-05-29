using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationSettingDifficulty
{
    public string Part { get; set; } = null!;

    public string? Difficulty { get; set; }

    public bool? IsActive { get; set; }
}
