using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProdFlexPartListHistory
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string? PartNumber { get; set; }

    public string? RevisionNumber { get; set; }

    public string? PartType { get; set; }

    public string? Weight { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public int? UserId { get; set; }

    public string? Approved { get; set; }

    public DateTime? UploadDate { get; set; }

    public DateTime? ChangeDate { get; set; }
}
