using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FpaColorGradeHistory
{
    public int Id { get; set; }

    public string? ColourPartno { get; set; }

    public string? ColorCode1 { get; set; }

    public string? ColourNameMaterialGrade1 { get; set; }

    public string? ColourNameMaterialGrade2 { get; set; }

    public string? ColorCode2 { get; set; }
}
