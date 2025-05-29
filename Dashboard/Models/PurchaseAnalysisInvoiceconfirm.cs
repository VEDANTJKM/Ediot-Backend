using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PurchaseAnalysisInvoiceconfirm
{
    public int Id { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public int? Pono { get; set; }

    public int? Epono { get; set; }

    public int? Line { get; set; }

    public DateTime? InwardDate { get; set; }

    public DateTime? PromiseDate { get; set; }

    public string? ItemName { get; set; }

    public string? TypeCode { get; set; }

    public string? SupName { get; set; }

    public string? Department { get; set; }

    public string? ClassId { get; set; }

    public string? ClassDesc { get; set; }

    public string? Category { get; set; }

    public string? Hsn { get; set; }

    public string? ChallanNo { get; set; }

    public string? RequisitionNo { get; set; }

    public decimal? Poqty { get; set; }

    public decimal? ReceivedQty { get; set; }

    public string? Uom { get; set; }

    public decimal? AcceptedQty { get; set; }

    public decimal? Uaqty { get; set; }

    public decimal? RejSuppEnd { get; set; }

    public decimal? Cd { get; set; }

    public string? Remark { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Gstpercentage { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Gstamount { get; set; }

    public decimal? TransportationCharges { get; set; }

    public decimal? FreightCharges { get; set; }

    public decimal? PackingOrCuttingCharges { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? IsConfirmed { get; set; }

    public bool? IsDelete { get; set; }

    public decimal? Qr { get; set; }

    public int? DelayinDays { get; set; }

    public decimal? DeliveryRating { get; set; }

    public decimal? Averagerating { get; set; }

    public string? OverallRating { get; set; }

    public int? Addedby { get; set; }

    public string? UploadedFile { get; set; }

    public DateTime Timestap { get; set; }

    public string? EntryType { get; set; }
}
