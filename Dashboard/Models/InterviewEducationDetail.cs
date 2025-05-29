using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class InterviewEducationDetail
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int? PersonalId { get; set; }

    public DateOnly? AcademicYear { get; set; }

    public string? CourseName { get; set; }

    public string? SchoolCollegeName { get; set; }

    public string? MainSubject { get; set; }

    public string? Percentage { get; set; }
}
