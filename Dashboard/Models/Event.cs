using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Event
{
    public int EventId { get; set; }

    public string? Subject { get; set; }

    public string? Description { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? Endd { get; set; }

    public string? ThemeColor { get; set; }

    public bool? IsFullDay { get; set; }
}
