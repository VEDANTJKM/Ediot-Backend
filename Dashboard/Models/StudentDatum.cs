using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class StudentDatum
{
    public int Id { get; set; }

    public string? Rollno { get; set; }

    public string? StudentName { get; set; }

    public string? Standard { get; set; }

    public string? TeacherName { get; set; }
}
