using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PurchaseAnalysisDataFromErp
{
    public int Id { get; set; }

    public int Ponum { get; set; }

    public string PackSlip { get; set; } = null!;

    public int Poline { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? PartNum { get; set; }

    public decimal? OurQty { get; set; }

    public decimal? DocUnitCost { get; set; }

    public DateTime? DueDate { get; set; }

    public string? ClassId { get; set; }

    public decimal? OrderQty { get; set; }

    public string? Ium { get; set; }

    public string? CommentText { get; set; }

    public string? TaxCatId { get; set; }

    public decimal? ExtCost { get; set; }

    public decimal? TotalDedTax { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? ClassDescription { get; set; }

    public string? VendorId { get; set; }

    public string? VendorName { get; set; }

    public bool? OpenLine { get; set; }
}
