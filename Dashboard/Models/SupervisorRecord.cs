using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class SupervisorRecord
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public string? HigherAuth { get; set; }

    public string? Name { get; set; }

    public string? IdName { get; set; }
}
