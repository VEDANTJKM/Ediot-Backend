using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class HibcApprentixTable
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? ApprentixName { get; set; }

    public int? ApprentixValue { get; set; }
}
