using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TaskManagementTrial
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string TaskId { get; set; } = null!;

    public string? TaskName { get; set; }

    public string? TaskRemark { get; set; }

    public DateTime? TaskDate { get; set; }

    public decimal? TaskHour { get; set; }

    public string? TaskAssigned { get; set; }

    public bool? Complete { get; set; }
}
