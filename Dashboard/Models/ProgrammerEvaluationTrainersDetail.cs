using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationTrainersDetail
{
    public int Id { get; set; }

    public int? TtId { get; set; }

    public int? TrainnerId { get; set; }
}
