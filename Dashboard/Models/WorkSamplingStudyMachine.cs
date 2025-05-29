using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class WorkSamplingStudyMachine
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string EventId { get; set; } = null!;

    public string? EventName { get; set; }

    public string? MachineName { get; set; }

    public string? OperatorId { get; set; }

    public string? MachineStatus { get; set; }

    public string? OperatorStatus { get; set; }

    public string? MachineNo { get; set; }

    public DateTime? SamplingDate { get; set; }

    public TimeOnly? SamplingTime { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? UplodBy { get; set; }

    public bool? UploadYn { get; set; }
}
