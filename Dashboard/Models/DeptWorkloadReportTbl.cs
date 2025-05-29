using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptWorkloadReportTbl
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Rid { get; set; }

    public DateTime? ReportingDate { get; set; }

    public string? Remarks { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }
}
