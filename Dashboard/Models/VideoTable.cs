using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class VideoTable
{
    public int Mid { get; set; }

    public int Vid { get; set; }

    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Type { get; set; }

    public string? Url { get; set; }

    public bool? Active { get; set; }
}
