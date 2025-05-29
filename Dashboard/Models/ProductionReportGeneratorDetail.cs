using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionReportGeneratorDetail
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public string? PersonName { get; set; }

    public string? PersonType { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? ToolTrialUserType { get; set; }
}
