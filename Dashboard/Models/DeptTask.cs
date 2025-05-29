using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptTask
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? ProjectName { get; set; }

    public string? TaskTitle { get; set; }

    public string? TaskDescription { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? TaskFile { get; set; }

    public string? TaskTags { get; set; }

    public string? TaskProgress { get; set; }

    public string? CompletedBy { get; set; }

    public string? Status { get; set; }

    public string? UploadBy { get; set; }
}
