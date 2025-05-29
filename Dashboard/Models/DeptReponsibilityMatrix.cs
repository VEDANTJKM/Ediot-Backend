using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptReponsibilityMatrix
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Process { get; set; }

    public string? Role { get; set; }

    public string? Person { get; set; }

    public string? Responsibility { get; set; }

    public string? UploadBy { get; set; }

    public DateOnly? UploadDate { get; set; }

    public string? Department { get; set; }
}
