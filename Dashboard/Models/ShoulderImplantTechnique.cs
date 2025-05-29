using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ShoulderImplantTechnique
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Technique { get; set; }

    public string? Step1 { get; set; }

    public string? Step2 { get; set; }

    public string? Step3 { get; set; }
}
