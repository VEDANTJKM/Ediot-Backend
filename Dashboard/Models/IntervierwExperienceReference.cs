using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class IntervierwExperienceReference
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int? PersonalId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Designation { get; set; }

    public string? MonthlySalary { get; set; }

    public string? Type { get; set; }

    public string? ContactNo { get; set; }

    public string? MainSubject { get; set; }
}
