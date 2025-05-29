using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationDiscipline
{
    public int Id { get; set; }

    public int? ProgrammerId { get; set; }

    public string? Personname { get; set; }

    public string? Discipline { get; set; }

    public int? Shift { get; set; }

    public string? Description { get; set; }

    public DateTime? CurrentDateTime { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }
}
