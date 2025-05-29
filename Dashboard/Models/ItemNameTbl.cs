using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ItemNameTbl
{
    public int Id { get; set; }

    public string? ItemName { get; set; }

    public byte? IsDeleted { get; set; }
}
