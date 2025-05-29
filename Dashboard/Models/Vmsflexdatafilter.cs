using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Vmsflexdatafilter
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Organization { get; set; }

    public string? Shift1 { get; set; }

    public string? Shift2 { get; set; }

    public string? Shift3 { get; set; }
}
