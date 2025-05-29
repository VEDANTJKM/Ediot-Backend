using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationTraining
{
    public int Id { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? ProgrammerName { get; set; }

    public string? TrainningTopic { get; set; }

    public string? TrainningDesc { get; set; }

    public string? TrainerName { get; set; }

    public string? Status { get; set; }

    public DateTime? TrainningStartTime { get; set; }

    public DateTime? TrainningEndTime { get; set; }

    public string? Files { get; set; }

    public int? UserId { get; set; }

    public bool? IsAccountable { get; set; }

    public string? SupervisiorRemark { get; set; }

    public TimeOnly? DurationHour { get; set; }

    public string? TrainningType { get; set; }
}
