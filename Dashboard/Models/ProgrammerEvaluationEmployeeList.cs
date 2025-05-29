using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationEmployeeList
{
    public int Id { get; set; }

    public string? UserType { get; set; }

    public bool? IsActive { get; set; }

    public bool Isapproved { get; set; }

    public string? ApprovedBy { get; set; }

    public string? EmployeeName { get; set; }

    public DateTime? Timestamp { get; set; }

    public int? UserId { get; set; }

    public bool? Active { get; set; }

    public bool? IsDeleted { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int MaxbonusAmmount { get; set; }

    public DateTime? DeleteTimespan { get; set; }

    public string? LoginIpaddress { get; set; }

    public DateTime? LoginTime { get; set; }

    public string? Type { get; set; }

    public DateTime? JoiningDate { get; set; }

    public string? Education { get; set; }

    public string? Department { get; set; }

    public string? AddedBy { get; set; }

    public string? Position { get; set; }
}
