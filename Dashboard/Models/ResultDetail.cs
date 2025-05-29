using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ResultDetail
{
    public int ResultId { get; set; }

    public int? Id { get; set; }

    public string? CboQuestionSets { get; set; }

    public int? QNo { get; set; }

    public string? Qlquestion { get; set; }

    public string? Givenans { get; set; }

    public string? Correctans { get; set; }

    public string? Result { get; set; }
}
