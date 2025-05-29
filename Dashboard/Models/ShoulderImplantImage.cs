using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ShoulderImplantImage
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? PartName { get; set; }

    public string? PartDescription { get; set; }

    public string? PartImage { get; set; }
}
