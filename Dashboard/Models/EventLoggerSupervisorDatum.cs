using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EventLoggerSupervisorDatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public DateOnly? EventDate { get; set; }

    public string? Shift { get; set; }

    public string? OperatorId { get; set; }

    public string? SupervisorId { get; set; }

    public string? OperatorType { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? MachineType { get; set; }

    public string? MachineName { get; set; }

    public string? Dept { get; set; }

    public string? Uploadby { get; set; }

    public DateTime? Uploaddate { get; set; }
}
