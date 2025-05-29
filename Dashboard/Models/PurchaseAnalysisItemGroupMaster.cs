using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PurchaseAnalysisItemGroupMaster
{
    public int Id { get; set; }

    public string ItemGroup { get; set; } = null!;

    public bool? IsDeleted { get; set; }
}
