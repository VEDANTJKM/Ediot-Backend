using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TicketGenerationApplicationRevisionDetail
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string TicketNo { get; set; } = null!;

    public string? RevisionType { get; set; }

    public string? VersionNo { get; set; }

    public string? ReleaseNotes { get; set; }

    public string? Link { get; set; }

    public string? Status { get; set; }

    public string? Department { get; set; }

    public int? VesrionNoGen { get; set; }

    public int? VersionNoTwo { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public DateTime? DenyDate { get; set; }
}
