using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EpoApproval
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Epo { get; set; }

    public string? Employee { get; set; }

    public string? Manager { get; set; }

    public string? Mpc { get; set; }

    public string? HigherAuthority { get; set; }

    public decimal? EmployeeLimit { get; set; }

    public decimal? ManagerLimit { get; set; }

    public decimal? MpcLimit { get; set; }

    public string? SelfApproval { get; set; }

    public string? ManagerApproval { get; set; }

    public string? MpcApproval { get; set; }

    public string? MpcHigherApproval { get; set; }

    public string? Active { get; set; }

    public DateTime? EmployeeApprovalDate { get; set; }

    public DateTime? ManagerApprovalDate { get; set; }

    public DateTime? MpcApprovalDate { get; set; }

    public DateTime? MpcHigherApprovalDate { get; set; }
}
