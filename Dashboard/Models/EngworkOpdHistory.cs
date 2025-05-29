using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkOpdHistory
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public int Mid { get; set; }

    public bool? Dxfrequired { get; set; }

    public DateTime? DxfavilableDate { get; set; }

    public string? Dxfremark { get; set; }

    public int? OpdrequestFrom { get; set; }

    public string? OpdrequirementDescription { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? OpdcorrectionDate { get; set; }

    public DateTime? StageDrawingAvilableDate { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public int? IsSavedBy { get; set; }

    public int? IsSubmitedBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
