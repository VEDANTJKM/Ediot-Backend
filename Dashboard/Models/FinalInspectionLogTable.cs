using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionLogTable
{
    public int Id { get; set; }

    public DateTime? CurrentDateTime { get; set; }

    public string? Message { get; set; }

    public string? Exception { get; set; }

    public string? PageName { get; set; }

    public int? LineNumber { get; set; }

    public string? MethodName { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }
}
