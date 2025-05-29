using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptPersonalGrowth
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? ProjectName { get; set; }

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Department { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }
}
