using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkMaterialSuggestionHistory
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public int Mid { get; set; }

    public string? MaterialGrade { get; set; }

    public decimal? PartDimension { get; set; }

    public string? MaterialPartName { get; set; }

    public string? MaterialDescription { get; set; }

    public decimal? Uom { get; set; }

    public DateTime? MaterialEmailDate { get; set; }

    public decimal? Calculator { get; set; }

    public decimal? QtyPerParent { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public bool? IsSavedBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
