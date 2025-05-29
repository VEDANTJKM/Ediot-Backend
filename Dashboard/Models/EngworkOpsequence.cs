using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkOpsequence
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public string? Opsequence { get; set; }

    public string? Process { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public bool? IsSavedBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
