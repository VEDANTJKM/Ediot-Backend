using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchBoxDropDown
{
    public int Id { get; set; }

    public string? BoxName { get; set; }

    public string? BoxValue { get; set; }

    public decimal? EmptyBoxWeight { get; set; }

    public bool? ActiveLogs { get; set; }
}
