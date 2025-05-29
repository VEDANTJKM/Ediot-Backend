using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EmpLimit
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? EmpDept { get; set; }

    public string? EmpManager { get; set; }

    public decimal? EmpLimitnew { get; set; }

    public int? PreviousEmpLimitNo { get; set; }

    public decimal? PreviousEmpLimit1 { get; set; }

    public decimal? PreviousEmpLimit2 { get; set; }

    public decimal? PreviousEmpLimit3 { get; set; }

    public decimal? PreviousEmpLimit4 { get; set; }

    public decimal? PreviousEmpLimit5 { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? RevisedDate1 { get; set; }

    public DateTime? RevisedDate2 { get; set; }

    public DateTime? RevisedDate3 { get; set; }

    public DateTime? RevisedDate4 { get; set; }

    public DateTime? RevisedDate5 { get; set; }

    public string? MpcMember { get; set; }

    public string? MpcNumber { get; set; }
}
