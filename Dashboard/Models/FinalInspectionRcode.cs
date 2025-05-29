using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionRcode
{
    public int Id { get; set; }

    public string Rcode { get; set; } = null!;

    public string Description { get; set; } = null!;
}
