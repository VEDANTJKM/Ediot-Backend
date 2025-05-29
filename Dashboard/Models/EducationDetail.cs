using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EducationDetail
{
    public int EducationId { get; set; }

    public int Id { get; set; }

    public int Academicyear { get; set; }

    public string Course { get; set; } = null!;

    public string School { get; set; } = null!;

    public string Mainsubject { get; set; } = null!;

    public decimal Percentage { get; set; }
}
