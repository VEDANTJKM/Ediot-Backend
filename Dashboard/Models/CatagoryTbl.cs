using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class CatagoryTbl
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public bool? IsDeleted { get; set; }
}
