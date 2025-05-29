using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptWorkloadSubtaskTbl
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Rid { get; set; }

    public string? ProjectName { get; set; }

    public string? SubTask { get; set; }

    public string? Department { get; set; }

    public int? ResponsibilityPersonId { get; set; }

    public DateTime? DeadLine { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }
}
