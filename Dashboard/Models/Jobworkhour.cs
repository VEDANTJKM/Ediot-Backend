using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Jobworkhour
{
    public string Gpno { get; set; } = null!;

    public string? Suppliername { get; set; }

    public string? Countinghour { get; set; }
}
