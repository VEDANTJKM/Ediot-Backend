using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PurchaseAnalysisPartDepartment
{
    public int Id { get; set; }

    public string? PartName { get; set; }

    public string? Department { get; set; }

    public string? Category { get; set; }
}
