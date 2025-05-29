using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TicketGeneratedDepartmentApplicable
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string TicketId { get; set; } = null!;

    public string? ApplicableDepartment { get; set; }
}
