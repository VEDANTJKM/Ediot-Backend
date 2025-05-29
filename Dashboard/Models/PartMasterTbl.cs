using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PartMasterTbl
{
    public int Id { get; set; }

    public string PartNum { get; set; } = null!;

    public string? PartDescription { get; set; }

    public string? Uom { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsLotRequired { get; set; }
}
