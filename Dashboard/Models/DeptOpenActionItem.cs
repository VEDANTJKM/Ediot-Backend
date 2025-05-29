using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptOpenActionItem
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Department { get; set; }

    public string? Catagory { get; set; }

    public string? ProjectList { get; set; }

    public bool HasSubTask { get; set; }

    public string? SubTask { get; set; }

    public string? AssignedBy { get; set; }

    public string? Lead { get; set; }

    public string? AssignedTo { get; set; }

    public string? Team { get; set; }

    public string? ProjectDescription { get; set; }

    public DateTime? DateAssigned { get; set; }

    public DateTime? ActualStartDate { get; set; }

    public DateTime? EstimatedEndDate { get; set; }

    public DateTime? ActualEndDate { get; set; }

    public string? ProjectStatus { get; set; }

    public string? ReleventInformation { get; set; }

    public string? Links { get; set; }

    public string? Remarks { get; set; }
}
