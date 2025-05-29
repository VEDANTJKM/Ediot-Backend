using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EmpTrainingMaster
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Department { get; set; }

    public string? SubDepartment { get; set; }

    public string? CourceName { get; set; }

    public string? SummaryOfContent { get; set; }

    public decimal? Hours { get; set; }

    public string? Location { get; set; }
}
