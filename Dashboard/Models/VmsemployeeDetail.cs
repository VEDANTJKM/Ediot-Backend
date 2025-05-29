using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class VmsemployeeDetail
{
    public string PersonId { get; set; } = null!;

    public string? Organization { get; set; }

    public string? PersonName { get; set; }

    public string? Gender { get; set; }

    public DateTime? EffectiveTime { get; set; }

    public DateTime? ExpiryTime { get; set; }

    public string? Cardno { get; set; }

    public string? Roomno { get; set; }

    public string? Floorno { get; set; }

    public string? Picture { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public DateOnly? Dob { get; set; }

    public DateOnly? Doj { get; set; }

    public DateOnly? Doi { get; set; }

    public string? Bloodgroup { get; set; }

    public string? Signature { get; set; }

    public string? EmailAddress { get; set; }

    public string? EmpPosition { get; set; }

    public string? ReportingUnder { get; set; }

    public string? BdayCards { get; set; }

    public string? ApprovalForDocument { get; set; }

    public bool? Active { get; set; }

    public DateTime? UploadDate { get; set; }

    public bool? IssueIcard { get; set; }

    public bool? Uniform { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Department { get; set; }
}
