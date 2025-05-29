using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ShoulderImplantMaster
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public int Refid { get; set; }

    public string? RefType { get; set; }

    public string? RerSubType { get; set; }

    public string? ManufacturerName { get; set; }

    public bool? Active { get; set; }
}
