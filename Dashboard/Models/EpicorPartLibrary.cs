using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EpicorPartLibrary
{
    public int Id { get; set; }

    public string? PartNum { get; set; }

    public string? SystemName { get; set; }

    public string? PartDescription { get; set; }

    public string? TypeCode { get; set; }

    public string? Warehouse { get; set; }

    public string? BinNo { get; set; }

    public decimal? OnHandQtySn { get; set; }

    public decimal? OnHandQtyFl { get; set; }

    public string? Uom { get; set; }

    public bool? Inactive { get; set; }

    public string? Company { get; set; }

    public string? ClassId { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? SearchWord { get; set; }

    public decimal? CycleTime { get; set; }
}
