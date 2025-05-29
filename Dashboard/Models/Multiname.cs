using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Multiname
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public string Reqno { get; set; } = null!;

    public string? Name { get; set; }
}
