using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TaskManagementTrialSecondary
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string TaskId { get; set; } = null!;

    public string AssignId { get; set; } = null!;

    public string? TaskName { get; set; }

    public DateTime? TaskDate { get; set; }

    public decimal? TaskHour { get; set; }

    public string? TaskAssigned { get; set; }

    public bool? Complete { get; set; }

    public DateOnly? TaskStartDate { get; set; }

    public string? TaskStartTime { get; set; }

    public DateOnly? TaskEndDate { get; set; }

    public string? TaskEndTime { get; set; }

    public string? TaskStatus { get; set; }
}
