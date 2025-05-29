using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptInterviewQuestion
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Question { get; set; }

    public string? TypeOfQuestion { get; set; }

    public string? ExpectedResponse { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? Department { get; set; }
}
