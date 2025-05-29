using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MrsSupervisorApproval
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public string? HigherAuth { get; set; }
}
