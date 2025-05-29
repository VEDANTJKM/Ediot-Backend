using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TpmPurchaseInvoiceDetail
{
    public int Id { get; set; }

    public string Ponum { get; set; } = null!;

    public bool? OpenOrder { get; set; }

    public string PackSlip { get; set; } = null!;

    public DateTime? ReceiptDate { get; set; }

    public string PartNum { get; set; } = null!;

    public decimal? OurQty { get; set; }

    public decimal? DocUnitCost { get; set; }

    public string VendorName { get; set; } = null!;

    public int? Poline { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? DueDate { get; set; }

    public string CommodityCode { get; set; } = null!;

    public decimal? OrderQty { get; set; }

    public string TaxCatId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string Ium { get; set; } = null!;

    public string CommentText { get; set; } = null!;

    public decimal? ExtCost { get; set; }

    public decimal? TotalDedTax { get; set; }

    public decimal? TotalAmount { get; set; }
}
