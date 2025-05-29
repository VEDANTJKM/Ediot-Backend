using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EventNameMaster
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public string? EventName { get; set; }

    public bool? Active { get; set; }

    public string? RefName { get; set; }

    public string? EventId { get; set; }
}
