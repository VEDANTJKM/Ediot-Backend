using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ItemsOfEpoTemp
{
    public int Id { get; set; }

    public int LineNo { get; set; }

    public int Pid { get; set; }

    public string? ProductDescription { get; set; }

    public string? ProductGroup { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Unitprice { get; set; }

    public string? Uom { get; set; }

    public string? Dept { get; set; }

    public string? AccountNo { get; set; }

    public string? Gujarat { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Dis { get; set; }

    public decimal? UnitypriceQty { get; set; }

    public decimal? QtyUnitpriceTax { get; set; }

    public decimal? TotalcostDis { get; set; }

    public string? Gst { get; set; }

    public decimal? Cgst { get; set; }

    public decimal? Sgst { get; set; }

    public decimal? Igst { get; set; }

    public decimal? ExtendedCost { get; set; }

    public string? Purchase { get; set; }

    public int? EpoNo { get; set; }

    public decimal? ReceivedQty { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? CgstValue { get; set; }

    public decimal? SgstValue { get; set; }

    public decimal? TaxValue { get; set; }

    public decimal? IgstValue { get; set; }

    public string? CurrencyType { get; set; }
}
