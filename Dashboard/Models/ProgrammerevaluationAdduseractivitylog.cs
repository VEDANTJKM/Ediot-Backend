using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerevaluationAdduseractivitylog
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? Whoadded { get; set; }

    public string? Whoedited { get; set; }

    public string? Whodeleted { get; set; }

    public DateOnly? Addedtimespan { get; set; }

    public DateOnly? Editedtimespan { get; set; }

    public DateOnly? Deletetimespan { get; set; }

    public bool? Active { get; set; }

    public bool? Delete { get; set; }
}
