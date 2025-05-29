using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MdrPartDatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string MdrNo { get; set; } = null!;

    public string? SystemName { get; set; }

    public string? ProductName { get; set; }

    public string? Description { get; set; }

    public string? SubSystem { get; set; }

    public bool? RefPart { get; set; }

    public string? SubRefPart { get; set; }

    public string? ManufacturingProduction { get; set; }

    public string? AssemblyPart { get; set; }

    public string? SubRefPartDesc { get; set; }

    public bool? Allow { get; set; }
}
