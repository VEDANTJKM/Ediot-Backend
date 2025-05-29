using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ResponsibilityMatrix
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? ResponsibilityType { get; set; }

    public string? Activity { get; set; }

    public bool? SrSoftwareDeveloper { get; set; }

    public bool? SoftwareDeveloper { get; set; }

    public bool? JrSoftwareDeveloper { get; set; }

    public bool? TraineeDeveloper { get; set; }
}
