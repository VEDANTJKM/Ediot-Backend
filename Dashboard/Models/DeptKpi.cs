using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptKpi
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Process { get; set; }

    public bool HasSubProcess { get; set; }

    public string? SubProcess { get; set; }

    public string? Kpi { get; set; }

    public string? Owner { get; set; }

    public double? Ytd { get; set; }

    public double? ActualYtd { get; set; }

    public string? Status { get; set; }

    public double? KpiMonth { get; set; }

    public DateOnly? KpiDate { get; set; }

    public double? KpiYear { get; set; }

    public double? PlanKpiCount { get; set; }

    public double? PlanAverageOfKpi { get; set; }

    public double? ActualKpiCount { get; set; }

    public double? ActualAverageOfKpi { get; set; }

    public string? Attachment { get; set; }

    public string? Uploadby { get; set; }

    public string? Department { get; set; }

    public DateOnly? Uploaddate { get; set; }
}
