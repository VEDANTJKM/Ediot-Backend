using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class InterviewAnswerVerify
{
    public int Iid { get; set; }

    public int Mid { get; set; }

    public int? PersonalId { get; set; }

    public string? Question { get; set; }

    public string? AnswerTicked { get; set; }

    public string? ActualAnswer { get; set; }

    public string? Type { get; set; }
}
