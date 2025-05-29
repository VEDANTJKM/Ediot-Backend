using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EventSecondaryMsm
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string EventId { get; set; } = null!;

    public string? EventName { get; set; }

    public string? EventTransferFor { get; set; }

    public bool? Active { get; set; }

    public DateTime? EventDate { get; set; }

    public string? EventTextboxid { get; set; }
}
