using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngWorkAdminPanelHistory
{
    public int Id { get; set; }

    public int? RuleId { get; set; }

    public string? FormName { get; set; }

    public string? Dependency { get; set; }

    public bool? Isactive { get; set; }

    public DateOnly? RuleStartDate { get; set; }

    public DateOnly? RuleEndDate { get; set; }
}
