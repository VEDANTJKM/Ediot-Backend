using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptWorkloadDistribution
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? MainTask { get; set; }

    public string? SubTask { get; set; }

    public string? Person { get; set; }

    public string? PrimaryResponsibility { get; set; }

    public string? SecondaryResponsibility { get; set; }

    public string? FrequencyOfTask { get; set; }

    public string? Attachment { get; set; }

    public string? Department { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }
}
