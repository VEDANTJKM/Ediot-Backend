using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MrsRequesterDatum
{
    public int SrNo { get; set; }

    public string? Name { get; set; }

    public string? Department { get; set; }

    public string? SubDepartment { get; set; }

    public int? EmployeeId { get; set; }

    public bool? IsActive { get; set; }
}
