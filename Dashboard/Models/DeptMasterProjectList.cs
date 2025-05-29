using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptMasterProjectList
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Department { get; set; }

    public string? Process { get; set; }

    public string? ProjectName { get; set; }

    public string? Category { get; set; }

    public string? ProjectDescription { get; set; }

    public string? TypeOfProject { get; set; }

    public string? AssignedBy { get; set; }

    public string? LeadPerson { get; set; }

    public string? AssignedTo { get; set; }

    public string? Team { get; set; }

    public string? Status { get; set; }

    public DateOnly? AssignedDate { get; set; }

    public DateOnly? ActualStartDate { get; set; }

    public DateOnly? ExpectedEndDate { get; set; }

    public DateOnly? ActualEndDate { get; set; }

    public string? Remark { get; set; }
}
