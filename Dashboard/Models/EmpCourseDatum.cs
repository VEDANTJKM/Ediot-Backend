using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EmpCourseDatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Courseid { get; set; }

    public string? CourseName { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public decimal? Hours { get; set; }

    public string? Location { get; set; }

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public string? AuthorName { get; set; }

    public bool? AddedDateAfterDueDate { get; set; }
}
