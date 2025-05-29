using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProdFlexCutShaftJobList
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? JobNumber { get; set; }

    public decimal? JobQty { get; set; }

    public string? PartNumber { get; set; }

    public string? RevisionNumber { get; set; }

    public int? PartId { get; set; }

    public string? PartType { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? UploadBy { get; set; }
}
