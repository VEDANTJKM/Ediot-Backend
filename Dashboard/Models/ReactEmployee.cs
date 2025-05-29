using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ReactEmployee
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? Department { get; set; }

    public DateTime? DateOfJoining { get; set; }

    public string? PhotoFileName { get; set; }
}
