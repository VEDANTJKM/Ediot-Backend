using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkPtd
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public int Mid { get; set; }

    public string? Ptdform { get; set; }

    public bool? StageDrawingRequired { get; set; }

    public DateTime? Ptddate { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public bool? IsSavedBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
