using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EventManagementWithTextboxValue
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string EventGeneratedId { get; set; } = null!;

    public string? EventName { get; set; }

    public string? EventId { get; set; }

    public bool? Active { get; set; }

    public string? EventLabel { get; set; }
}
