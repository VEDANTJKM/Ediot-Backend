using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class WorkingSamplingTime
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? MachineName { get; set; }

    public DateOnly? MachineRecordDate { get; set; }

    public TimeOnly? MachineRecordTime { get; set; }

    public string? TMachine { get; set; }
}
