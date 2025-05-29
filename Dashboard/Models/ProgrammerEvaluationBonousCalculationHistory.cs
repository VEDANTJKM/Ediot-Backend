using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationBonousCalculationHistory
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public decimal? Lower { get; set; }

    public decimal? Upper { get; set; }

    public int? Rating { get; set; }

    public decimal Bonous { get; set; }

    public DateTime? Timestamp { get; set; }

    public int? UserId { get; set; }
}
