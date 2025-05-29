using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkMaterialSuggestionDetail
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public string MaterialPartName { get; set; } = null!;

    public string? MaterialDescription { get; set; }

    public string? Uom { get; set; }

    public string? QtyperParent { get; set; }

    public decimal MaterialAvaQty { get; set; }

    public string? Grade { get; set; }
}
