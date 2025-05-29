using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Unit
{
    public int Mid { get; set; }

    public int Id { get; set; }

    public string? Unitname { get; set; }

    public string? Active { get; set; }

    public string? Type { get; set; }
}
