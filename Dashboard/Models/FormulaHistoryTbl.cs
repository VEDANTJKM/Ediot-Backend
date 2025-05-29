using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FormulaHistoryTbl
{
    public int Id { get; set; }

    public int? FormulaId { get; set; }

    public string? ActiveTime { get; set; }

    public string? DeactiveTime { get; set; }

    public string? ActiveBy { get; set; }

    public string? DeactiveBy { get; set; }
}
