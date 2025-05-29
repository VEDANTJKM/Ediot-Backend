using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EmployeeDetail
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? MobileNo { get; set; }

    public string? Status { get; set; }
}
