using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkMom
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public int Mid { get; set; }

    public DateTime? OpseqSheetCompleteDate { get; set; }

    public DateTime? MomcompleteDate { get; set; }

    public string? OpsequenceFileAttachment { get; set; }

    public string? ProcessRemark { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public bool? IsSavedBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
