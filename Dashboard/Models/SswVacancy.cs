using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class SswVacancy
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string? ApplicantName { get; set; }

    public string? ApplicantEmail { get; set; }

    public string? ApplicantMobile { get; set; }

    public string? ApplicantPosition { get; set; }

    public string? Attachment { get; set; }

    public bool? Active { get; set; }
}
