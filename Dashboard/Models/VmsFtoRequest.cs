using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class VmsFtoRequest
{
    public int Id { get; set; }

    public string PersonId { get; set; } = null!;

    public string? Personname { get; set; }

    public DateTime? Startdate { get; set; }

    public string? SLeaveType { get; set; }

    public DateTime? Enddate { get; set; }

    public string? ELeaveType { get; set; }

    public string? TypeOfLeave { get; set; }

    public string? OtherType { get; set; }

    public int? EflDaysGiven { get; set; }

    public int? EflDaysUsed { get; set; }

    public int? EflBalance { get; set; }

    public int? EflDaysRequested { get; set; }

    public int? EvlDaysGiven { get; set; }

    public int? EvlDaysUsed { get; set; }

    public int? EvlBalance { get; set; }

    public int? EvlDaysRequested { get; set; }

    public string? EmployeeComment { get; set; }

    public string? SupervisorNotes { get; set; }

    public string? HrNotes { get; set; }

    public string? SupervisorApproval { get; set; }

    public string? HrApproval { get; set; }

    public string? MpcApproval { get; set; }

    public decimal? EflDaysGivenNew { get; set; }

    public decimal? EflDaysUsedNew { get; set; }

    public decimal? EflBalanceNew { get; set; }

    public decimal? EflDaysRequestedNew { get; set; }

    public decimal? EvlDaysGivenNew { get; set; }

    public decimal? EvlDaysUsedNew { get; set; }

    public decimal? EvlBalanceNew { get; set; }

    public decimal? EvlDaysRequestedNew { get; set; }
}
