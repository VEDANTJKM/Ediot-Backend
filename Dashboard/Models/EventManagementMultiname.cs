using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EventManagementMultiname
{
    public int Id { get; set; }

    public string EventId { get; set; } = null!;

    public string? EmployeeId { get; set; }

    public DateTime? Uploaddate { get; set; }

    public string? Shift { get; set; }
}
