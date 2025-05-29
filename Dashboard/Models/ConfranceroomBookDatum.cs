using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ConfranceroomBookDatum
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? EventName { get; set; }

    public string? EventDate { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? Location { get; set; }

    public string? Description { get; set; }

    public string? UploadBy { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? End { get; set; }

    public string? Duration { get; set; }

    public int? Iid { get; set; }

    public string? Frequncy { get; set; }

    public string? ClassName { get; set; }
}
