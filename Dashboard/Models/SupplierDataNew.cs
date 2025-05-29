using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class SupplierDataNew
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string Sid { get; set; } = null!;

    public string? SuppName { get; set; }

    public string? SuppAdd { get; set; }

    public string? SuppMob { get; set; }

    public string? SuppEmail { get; set; }

    public string? SuppGst { get; set; }
}
