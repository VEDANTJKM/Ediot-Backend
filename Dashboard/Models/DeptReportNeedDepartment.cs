using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptReportNeedDepartment
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string? Data { get; set; }

    public string? Link { get; set; }

    public string? TypeOfDocument { get; set; }

    public string? Frequency { get; set; }

    public string? Department { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }
}
