using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchProvidedPackingDetailsPalate
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public string PallateType { get; set; } = null!;
}
