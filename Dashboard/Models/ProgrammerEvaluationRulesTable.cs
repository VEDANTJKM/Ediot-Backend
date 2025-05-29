using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationRulesTable
{
    public int Ruleid { get; set; }

    public DateTime Monthyear { get; set; }

    public DateTime Timestamp { get; set; }

    public int? SetupRuleId { get; set; }

    public int? SettingRuleId { get; set; }

    public int? ResettingRuleId { get; set; }

    public int? TraininggivenRuleId { get; set; }

    public int? TrainingtakenRuleId { get; set; }

    public int? DiciplineRuleId { get; set; }
}
