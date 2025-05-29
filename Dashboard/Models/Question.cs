using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Question
{
    public int Id { get; set; }

    public string Quiz { get; set; } = null!;

    public string Qset { get; set; } = null!;

    public string QNo { get; set; } = null!;

    public string Question1 { get; set; } = null!;

    public string OptionA { get; set; } = null!;

    public string OptionB { get; set; } = null!;

    public string? OptionC { get; set; }

    public string? OptionD { get; set; }

    public string Ans { get; set; } = null!;

    public byte[]? Image { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }
}
