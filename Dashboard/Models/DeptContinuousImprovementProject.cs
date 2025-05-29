using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptContinuousImprovementProject
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? CurrentGap { get; set; }

    public string? Consequencces { get; set; }

    public string? PlanToAddress { get; set; }

    public DateOnly? EstimatedCompletionDate { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public string? Remark { get; set; }

    public string? ReferenceDocument { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? Department { get; set; }
}
